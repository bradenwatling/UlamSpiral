using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Recognition;
using System.Text;
using System.Windows.Forms;

namespace UlamSpiral
{
    public partial class Main : Form
    {
        int spiralWidth = 2;

        List<SpiralNumber> spiralNumbers;

        Font drawFont;
        SolidBrush evenBrush;
        SolidBrush oddBrush;
        SolidBrush squareBrush;
        SolidBrush primeBrush;
        SolidBrush squarePrimeBrush;

        Size spiralSize;
        Size totalSpiralSize;
        Size fontSize;

        SpeechRecognitionEngine speechEngine = new SpeechRecognitionEngine();

        bool drawDots;
        bool squareCenter;

        public Main()
        {
            InitializeComponent();

            fontList.SelectedIndex = 0;
            squareCenter = squareButton.Checked;

            speechEngine.SpeechRecognized +=new EventHandler<SpeechRecognizedEventArgs>(speechEngine_SpeechRecognized);

            speechEngine.SetInputToDefaultAudioDevice();

            Choices choices = new Choices("primes", "squares", "dots", "numbers");

            foreach(string item in fontList.Items)
                choices.Add("set font " + item);

            for (int i = 0; i <= 999; ++i)
                choices.Add("set size " + i);

            GrammarBuilder grammarBuilder = new GrammarBuilder(choices);
            speechEngine.LoadGrammar(new Grammar(grammarBuilder));
            speechEngine.RecognizeAsync(RecognizeMode.Multiple);

            init();
        }

        private void init()
        {
            drawDots = drawDotsBox.Checked;

            spiralNumbers = new List<SpiralNumber>();

            drawFont = drawFont == null ? new Font("Times New Roman", 3) : drawFont;
            evenBrush = new SolidBrush(Color.Black);
            oddBrush = new SolidBrush(Color.Black);
            squareBrush = new SolidBrush(Color.Lime);
            primeBrush = new SolidBrush(Color.Magenta);
            squarePrimeBrush = new SolidBrush(Color.Cyan);

            spiralSize = new Size(spiralWidth, spiralWidth);

            using (Graphics g = this.CreateGraphics())
                fontSize = g.MeasureString(" ", drawFont).ToSize();

            containerPanel.Invalidate();
            viewPanel.Invalidate();

            spiralNumbers = drawSpiral();

            viewPanel.Bounds = new Rectangle(Point.Empty, totalSpiralSize);
        }

        private void speechEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string text = e.Result.Text;

            if (text.Contains("set font"))
            {
                int index = Convert.ToInt32(text.Split(' ')[2]);

                bool validIndex = false;

                foreach (string item in fontList.Items)
                    if (item == index.ToString())
                    {
                        validIndex = true;
                        break;
                    }
                if(validIndex)
                    fontList.SelectedIndex = index - 3;
                return;
            }
            else if (text.Contains("set size"))
            {
                int value = Convert.ToInt32(text.Split(' ')[2]);

                sizeBox.Text = value.ToString();
                return;
            }

            switch (text)
            {
                case "primes":
                    primeButton.Checked = true;
                    break;
                case "squares":
                    squareButton.Checked = true;
                    break;
                case "dots":
                    drawDotsBox.Checked = true;
                    break;
                case "numbers":
                    drawDotsBox.Checked = false;
                    break;
            }
        }

        private void viewPanel_Paint(object sender, PaintEventArgs e)
        {
            foreach (SpiralNumber spiralNumber in spiralNumbers)
                spiralNumber.draw(e.Graphics, drawFont, drawDots);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void sizeBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                sizeBox.KeyPress += new KeyPressEventHandler(sizeBox_KeyPress);
                spiralWidth = Convert.ToInt32(sizeBox.Text);

                init();
            }
            catch
            {
            }
        }

        private void sizeBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b') //Only allow numbers
                e.Handled = true;
        }

        private void fontList_SelectedIndexChanged(object sender, EventArgs e)
        {
            drawFont = new Font("Times New Roman", (float)Convert.ToDouble((sender as ListBox).SelectedItem));
            init();
        }

        private void drawDotsBox_CheckedChanged(object sender, EventArgs e)
        {
            init();
        }

        private void squareButton_CheckedChanged(object sender, EventArgs e)
        {
            squareCenter = squareButton.Checked;
            init();
        }

        private List<SpiralNumber> drawSpiral()
        {
            int rowWidth = 1, columnHeight = 1;
            int numNumbers = spiralSize.Width * spiralSize.Height;

            int horizontalSpacing = 2 * numNumbers.ToString().Length; //Compensate for the number of digits

            Size fontWidth = new Size(fontSize.Width * (drawDots ? 1 : horizontalSpacing), 0); //Dont add extra space for dots
            Size fontHeight = new Size(0, drawDots ? fontSize.Width : fontSize.Height); //Square dots or font height

            totalSpiralSize = new Size(fontWidth.Width * (spiralWidth + 2), fontHeight.Height * (spiralWidth + 2));

            Point pos = new Point(totalSpiralSize.Width / 2, totalSpiralSize.Height / 2);
            pos -= fontWidth + fontHeight;

            List<SpiralNumber> numbers = new List<SpiralNumber>();

            int numberValue = 1;

            if (!squareCenter)
            {
                numberValue = 41;
                numNumbers += numberValue - 1;
            }

            numbers.Add(new SpiralNumber(pos, calculateBrush(numberValue), numberValue++));

            while (numberValue <= numNumbers)
            {
                //Move right
                for (int i = 1; i <= rowWidth && numberValue <= numNumbers; ++i)
                {
                    pos += fontWidth;
                    numbers.Add(new SpiralNumber(pos, calculateBrush(numberValue), numberValue++));
                }
                ++rowWidth;

                //Move up
                for (int i = 1; i <= columnHeight && numberValue <= numNumbers; ++i)
                {
                    pos -= fontHeight;
                    numbers.Add(new SpiralNumber(pos, calculateBrush(numberValue), numberValue++));
                }
                ++columnHeight;

                //Move left
                for (int i = 1; i <= rowWidth && numberValue <= numNumbers; ++i)
                {
                    pos -= fontWidth;
                    numbers.Add(new SpiralNumber(pos, calculateBrush(numberValue), numberValue++));
                }
                ++rowWidth;

                //Move down
                for (int i = 1; i <= columnHeight && numberValue<= numNumbers; ++i)
                {
                    pos += fontHeight;
                    numbers.Add(new SpiralNumber(pos, calculateBrush(numberValue), numberValue++));
                }
                ++columnHeight;
            }

            return numbers;
        }

        private bool isSquare(int num)
        {
            double sqrt = Math.Sqrt(num);

            return num % sqrt == 0;
        }

        private bool isPrime(int num)
        {
            if(num == 1 || num == 2) //One and two are special cases
                return true;
            if (num % 2 == 0) //Even numbers cant be prime
                return false;

            for (int i = 3; i <= num / 2; ++i) //We eliminated 1 and 2
                if (num % i == 0) //If the number is a factor of num
                    return false;

            return true;
        }

        private SolidBrush calculateBrush(int num)
        {
            SolidBrush brush;

            brush = num % 2 == 0 ? evenBrush : oddBrush;
            brush = isSquare(num) ? squareBrush : brush;
            brush = isPrime(num) ? primeBrush : brush;

            if (num == 1)
                brush = squarePrimeBrush; //1 is the only number that is a square and prime

            return brush;
        }
    }

    class SpiralNumber
    {
        public Point position;
        public SolidBrush brush;
        public int number;

        public SpiralNumber(Point p, SolidBrush b, int n)
        {
            position = p;
            brush = b;
            number = n;
        }

        public void draw(Graphics g, Font font, bool drawDots)
        {
            if (drawDots)
            {
                Size fontSize = g.MeasureString(" ", font).ToSize();

                Rectangle rect = new Rectangle(position.X, position.Y, fontSize.Width, fontSize.Width);
                g.FillRectangle(brush, rect);
            }
            else
                g.DrawString(number.ToString(), font, brush, position);
        }
    }
}

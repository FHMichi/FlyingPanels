namespace UE2_FlyingPanels
{
    public partial class Form1 : Form
    {
        //Richtung 1: links nach rechts, -1 rechts nach links
        private int direction = 1;
        private int speed = 1; 
        public Form1()
        {
            InitializeComponent();
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if(pan.Left + pan.Width >= this.ClientSize.Width)
            {
                direction = -1; 
            }

            if(pan.Left <= 0)
            {
                direction = 1; 
            }

            //Panel 3px nach rechts 
            pan.Left += speed * direction;

            /*
            lblPosition.Text = "Position: (" + pan.Left.ToString() + "/"
                                             + pan.Top.ToString() + ")"; */
            lblPosition.Text = $"Position: ({pan.Left}/{pan.Top})";
             
        }

        private void chkRun_CheckedChanged(object sender, EventArgs e)
        {
            //chkRun.Checked --> kurze Variante 
            /*
            if (chkRun.Checked == true)
            {
                tmr.Enabled = true;
            }
            else
            {
                tmr.Enabled = false;
            } 
            */
            tmr.Enabled = chkRun.Checked; 
        }

        private void trkSpeed_Scroll(object sender, EventArgs e)
        {
            //Konventierung nach Integer notwend
            speed = (int)trkSpeed.Value;
         
        }
    }
}
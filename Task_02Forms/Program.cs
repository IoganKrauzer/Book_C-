using System;
using System.Windows.Forms;



class MyButtonClass : Form
{
    private Button mrButton;
    public MyButtonClass()   // Метод конструктора
    {
        mrButton = new Button();
        mrButton.Text = "Нажми меня";
        mrButton.Top = 100;
        mrButton.Left = 100;
        mrButton.Height = 50;
        mrButton.Width = 70;
        mrButton.Click += new System.EventHandler(MyButtonClickEventHandler);  // Связываем событие нажатия кнопки с методом
        this.Controls.Add(mrButton);
    }
    static void Main()     // Основной метод
    {
        Application.Run(new MyButtonClass());
    }
    void MyButtonClickEventHandler(object x, EventArgs y)
    {
        mrButton.Text = "Вы нажали меня!";   // Обработчик событий
    }
}

// public void TheMouseIsDown(object sender, MouseEventArgs e)
// {
//     if (e.Button = MouseButtons.Left)
//     this.Text = "Нажата левая кнопка";
// }


//     public void ThisMouseWasClicked(object sender, EventArgs e)
//     {
//         if (e.Button == MouseButtons.Left)   // При нажатии левой кнопки
//         this.Width = this.Width + 100;
//         else if (e.Button == MouseButtons.Right)
//         this.Width = this.Width - 100;
//     }
// }



namespace Timer
{
    public partial class FormTimer : Form
    {
        int endTime;    // 終了時間の変数を整数型で定義
        int nowTime;    // 経過時間の変数を整数型で定義

        public FormTimer()
        {
            InitializeComponent();
        }

        // ボタンクリック時の処理
        private void buttonStart_Click(object sender, EventArgs e)
        {
            // 時間設定のTextBoxの内容を終了時間の変数に取得
            if (!int.TryParse(textSetTime.Text, out endTime))
            {
                endTime = 1;
            }

            // 残り時間を計算するために経過時間の変数を0で初期化
            nowTime = 0;

            // タイマースタート
            timerControl.Start();
        }

        // TimerコントロールのTickイベントのイベントハンドラー（タイマーの処理）
        private void timerControl_Tick(object sender, EventArgs e)
        {
            int remainingTime;  // 残り時間の変数を整数型で定義

            // 経過時間に1秒を加える
            nowTime++;

            // 残り時間を計算して表示
            remainingTime = endTime - nowTime;
            textRemainingTime.Text = remainingTime.ToString();

            // <判定>設定時間になった？
            // 「yes」の場合の処理
            if (endTime == nowTime)
            {
                // タイマーを止める
                timerControl.Stop();

                // 終了時間になったことを知らせる
                MessageBox.Show("時間になりました！");
            }
            // 「no」の場合の処理
            else
            {

            }



        }
    }
}

namespace Timer
{
    public partial class FormTimer : Form
    {
        int endTime;    // �I�����Ԃ̕ϐ��𐮐��^�Œ�`
        int nowTime;    // �o�ߎ��Ԃ̕ϐ��𐮐��^�Œ�`

        public FormTimer()
        {
            InitializeComponent();
        }

        // �{�^���N���b�N���̏���
        private void buttonStart_Click(object sender, EventArgs e)
        {
            // ���Ԑݒ��TextBox�̓��e���I�����Ԃ̕ϐ��Ɏ擾
            if (!int.TryParse(textSetTime.Text, out endTime))
            {
                endTime = 1;
            }

            // �c�莞�Ԃ��v�Z���邽�߂Ɍo�ߎ��Ԃ̕ϐ���0�ŏ�����
            nowTime = 0;

            // �^�C�}�[�X�^�[�g
            timerControl.Start();
        }

        // Timer�R���g���[����Tick�C�x���g�̃C�x���g�n���h���[�i�^�C�}�[�̏����j
        private void timerControl_Tick(object sender, EventArgs e)
        {
            int remainingTime;  // �c�莞�Ԃ̕ϐ��𐮐��^�Œ�`

            // �o�ߎ��Ԃ�1�b��������
            nowTime++;

            // �c�莞�Ԃ��v�Z���ĕ\��
            remainingTime = endTime - nowTime;
            textRemainingTime.Text = remainingTime.ToString();

            // <����>�ݒ莞�ԂɂȂ����H
            // �uyes�v�̏ꍇ�̏���
            if (endTime == nowTime)
            {
                // �^�C�}�[���~�߂�
                timerControl.Stop();

                // �I�����ԂɂȂ������Ƃ�m�点��
                MessageBox.Show("���ԂɂȂ�܂����I");
            }
            // �uno�v�̏ꍇ�̏���
            else
            {

            }



        }
    }
}

namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_handle_평가손익 = new System.Windows.Forms.Label();
            this.lbl_handle_진입단가 = new System.Windows.Forms.Label();
            this.lbl_handle_수량 = new System.Windows.Forms.Label();
            this.lbl_handle_포지션 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_평가손익 = new System.Windows.Forms.Label();
            this.lbl_진입단가 = new System.Windows.Forms.Label();
            this.lbl_수량 = new System.Windows.Forms.Label();
            this.lbl_포지션 = new System.Windows.Forms.Label();
            this.lbl_handle_계약수 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btn_매수스위칭 = new System.Windows.Forms.Button();
            this.btn_매도스위칭 = new System.Windows.Forms.Button();
            this.btn_매수 = new System.Windows.Forms.Button();
            this.btn_청산 = new System.Windows.Forms.Button();
            this.btn_매도 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbl_크기확인 = new System.Windows.Forms.Label();
            this.chk_몸통크기 = new System.Windows.Forms.CheckBox();
            this.nud_몸통크기 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_일괄취소 = new System.Windows.Forms.Button();
            this.lbl_진입중 = new System.Windows.Forms.Label();
            this.lbl_현재시간 = new System.Windows.Forms.Label();
            this.lbl_작동중타이틀 = new System.Windows.Forms.Label();
            this.chk_자동스위칭 = new System.Windows.Forms.CheckBox();
            this.chk_자동매도 = new System.Windows.Forms.CheckBox();
            this.lbl_매도발생 = new System.Windows.Forms.Label();
            this.lbl_매수발생 = new System.Windows.Forms.Label();
            this.lbl_매도컬러 = new System.Windows.Forms.Label();
            this.lbl_매수컬러 = new System.Windows.Forms.Label();
            this.chk_자동매수 = new System.Windows.Forms.CheckBox();
            this.lbl_매도신호 = new System.Windows.Forms.Label();
            this.lbl_매수신호 = new System.Windows.Forms.Label();
            this.btn_매도설정 = new System.Windows.Forms.Button();
            this.btn_매수설정 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_종료시간 = new System.Windows.Forms.DateTimePicker();
            this.dtp_시작시간 = new System.Windows.Forms.DateTimePicker();
            this.btn_자동주문 = new System.Windows.Forms.Button();
            this.lbl_영역좌표 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_영역크기 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_인식영역선택 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbl_1픽셀은 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl_1포인트는 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nud_포인트값 = new System.Windows.Forms.NumericUpDown();
            this.lbl_봉크기 = new System.Windows.Forms.Label();
            this.lbl_몸통크기 = new System.Windows.Forms.Label();
            this.btn_몸통확인 = new System.Windows.Forms.Button();
            this.btn_테스트작동 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_몸통크기)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_포인트값)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_handle_평가손익);
            this.groupBox1.Controls.Add(this.lbl_handle_진입단가);
            this.groupBox1.Controls.Add(this.lbl_handle_수량);
            this.groupBox1.Controls.Add(this.lbl_handle_포지션);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.lbl_handle_계약수);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(16, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HTS 프로그램 선택";
            // 
            // lbl_handle_평가손익
            // 
            this.lbl_handle_평가손익.BackColor = System.Drawing.Color.White;
            this.lbl_handle_평가손익.Location = new System.Drawing.Point(319, 66);
            this.lbl_handle_평가손익.Name = "lbl_handle_평가손익";
            this.lbl_handle_평가손익.Size = new System.Drawing.Size(100, 13);
            this.lbl_handle_평가손익.TabIndex = 19;
            this.lbl_handle_평가손익.Visible = false;
            // 
            // lbl_handle_진입단가
            // 
            this.lbl_handle_진입단가.BackColor = System.Drawing.Color.White;
            this.lbl_handle_진입단가.Location = new System.Drawing.Point(213, 66);
            this.lbl_handle_진입단가.Name = "lbl_handle_진입단가";
            this.lbl_handle_진입단가.Size = new System.Drawing.Size(100, 13);
            this.lbl_handle_진입단가.TabIndex = 18;
            this.lbl_handle_진입단가.Visible = false;
            // 
            // lbl_handle_수량
            // 
            this.lbl_handle_수량.BackColor = System.Drawing.Color.White;
            this.lbl_handle_수량.Location = new System.Drawing.Point(107, 66);
            this.lbl_handle_수량.Name = "lbl_handle_수량";
            this.lbl_handle_수량.Size = new System.Drawing.Size(100, 13);
            this.lbl_handle_수량.TabIndex = 17;
            this.lbl_handle_수량.Visible = false;
            // 
            // lbl_handle_포지션
            // 
            this.lbl_handle_포지션.BackColor = System.Drawing.Color.White;
            this.lbl_handle_포지션.Location = new System.Drawing.Point(1, 66);
            this.lbl_handle_포지션.Name = "lbl_handle_포지션";
            this.lbl_handle_포지션.Size = new System.Drawing.Size(100, 13);
            this.lbl_handle_포지션.TabIndex = 16;
            this.lbl_handle_포지션.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_평가손익);
            this.groupBox3.Controls.Add(this.lbl_진입단가);
            this.groupBox3.Controls.Add(this.lbl_수량);
            this.groupBox3.Controls.Add(this.lbl_포지션);
            this.groupBox3.Location = new System.Drawing.Point(8, 82);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(461, 59);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "포지션 정보";
            // 
            // lbl_평가손익
            // 
            this.lbl_평가손익.BackColor = System.Drawing.Color.White;
            this.lbl_평가손익.Location = new System.Drawing.Point(324, 24);
            this.lbl_평가손익.Name = "lbl_평가손익";
            this.lbl_평가손익.Size = new System.Drawing.Size(100, 13);
            this.lbl_평가손익.TabIndex = 15;
            // 
            // lbl_진입단가
            // 
            this.lbl_진입단가.BackColor = System.Drawing.Color.White;
            this.lbl_진입단가.Location = new System.Drawing.Point(218, 24);
            this.lbl_진입단가.Name = "lbl_진입단가";
            this.lbl_진입단가.Size = new System.Drawing.Size(100, 13);
            this.lbl_진입단가.TabIndex = 14;
            // 
            // lbl_수량
            // 
            this.lbl_수량.BackColor = System.Drawing.Color.White;
            this.lbl_수량.Location = new System.Drawing.Point(112, 24);
            this.lbl_수량.Name = "lbl_수량";
            this.lbl_수량.Size = new System.Drawing.Size(100, 13);
            this.lbl_수량.TabIndex = 13;
            // 
            // lbl_포지션
            // 
            this.lbl_포지션.BackColor = System.Drawing.Color.White;
            this.lbl_포지션.Location = new System.Drawing.Point(6, 24);
            this.lbl_포지션.Name = "lbl_포지션";
            this.lbl_포지션.Size = new System.Drawing.Size(100, 13);
            this.lbl_포지션.TabIndex = 12;
            // 
            // lbl_handle_계약수
            // 
            this.lbl_handle_계약수.BackColor = System.Drawing.Color.White;
            this.lbl_handle_계약수.Location = new System.Drawing.Point(105, 50);
            this.lbl_handle_계약수.Name = "lbl_handle_계약수";
            this.lbl_handle_계약수.Size = new System.Drawing.Size(100, 13);
            this.lbl_handle_계약수.TabIndex = 8;
            this.lbl_handle_계약수.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "계약수 EditBox";
            this.label2.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(386, 24);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 25);
            this.button4.TabIndex = 3;
            this.button4.Text = "갱신";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(23, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(357, 20);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.btn_매수스위칭);
            this.groupBox2.Controls.Add(this.btn_매도스위칭);
            this.groupBox2.Controls.Add(this.btn_매수);
            this.groupBox2.Controls.Add(this.btn_청산);
            this.groupBox2.Controls.Add(this.btn_매도);
            this.groupBox2.Location = new System.Drawing.Point(16, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(475, 204);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "수동 주문";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "기준계약수";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.numericUpDown1.Location = new System.Drawing.Point(188, 159);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(93, 29);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btn_매수스위칭
            // 
            this.btn_매수스위칭.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_매수스위칭.Location = new System.Drawing.Point(323, 130);
            this.btn_매수스위칭.Name = "btn_매수스위칭";
            this.btn_매수스위칭.Size = new System.Drawing.Size(133, 61);
            this.btn_매수스위칭.TabIndex = 4;
            this.btn_매수스위칭.Text = "매수스위칭\r\n(매도일 때)";
            this.btn_매수스위칭.UseVisualStyleBackColor = true;
            this.btn_매수스위칭.Click += new System.EventHandler(this.btn_매수스위칭_Click);
            // 
            // btn_매도스위칭
            // 
            this.btn_매도스위칭.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_매도스위칭.Location = new System.Drawing.Point(13, 130);
            this.btn_매도스위칭.Name = "btn_매도스위칭";
            this.btn_매도스위칭.Size = new System.Drawing.Size(133, 61);
            this.btn_매도스위칭.TabIndex = 3;
            this.btn_매도스위칭.Text = "매도스위칭\r\n(매수일 때)";
            this.btn_매도스위칭.UseVisualStyleBackColor = true;
            this.btn_매도스위칭.Click += new System.EventHandler(this.btn_매도스위칭_Click);
            // 
            // btn_매수
            // 
            this.btn_매수.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_매수.Location = new System.Drawing.Point(323, 38);
            this.btn_매수.Name = "btn_매수";
            this.btn_매수.Size = new System.Drawing.Size(133, 77);
            this.btn_매수.TabIndex = 2;
            this.btn_매수.Text = "시장가매수\r\n(F9)";
            this.btn_매수.UseVisualStyleBackColor = true;
            this.btn_매수.Click += new System.EventHandler(this.매수_Click);
            // 
            // btn_청산
            // 
            this.btn_청산.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_청산.Location = new System.Drawing.Point(168, 38);
            this.btn_청산.Name = "btn_청산";
            this.btn_청산.Size = new System.Drawing.Size(133, 77);
            this.btn_청산.TabIndex = 1;
            this.btn_청산.Text = "일괄청산\r\n(F11)";
            this.btn_청산.UseVisualStyleBackColor = true;
            this.btn_청산.Click += new System.EventHandler(this.청산_Click);
            // 
            // btn_매도
            // 
            this.btn_매도.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_매도.Location = new System.Drawing.Point(13, 38);
            this.btn_매도.Name = "btn_매도";
            this.btn_매도.Size = new System.Drawing.Size(133, 77);
            this.btn_매도.TabIndex = 0;
            this.btn_매도.Text = "시장가매도\r\n(F12)";
            this.btn_매도.UseVisualStyleBackColor = true;
            this.btn_매도.Click += new System.EventHandler(this.매도_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_테스트작동);
            this.groupBox4.Controls.Add(this.lbl_크기확인);
            this.groupBox4.Controls.Add(this.chk_몸통크기);
            this.groupBox4.Controls.Add(this.nud_몸통크기);
            this.groupBox4.Controls.Add(this.pictureBox2);
            this.groupBox4.Controls.Add(this.btn_일괄취소);
            this.groupBox4.Controls.Add(this.lbl_진입중);
            this.groupBox4.Controls.Add(this.lbl_현재시간);
            this.groupBox4.Controls.Add(this.lbl_작동중타이틀);
            this.groupBox4.Controls.Add(this.chk_자동스위칭);
            this.groupBox4.Controls.Add(this.chk_자동매도);
            this.groupBox4.Controls.Add(this.lbl_매도발생);
            this.groupBox4.Controls.Add(this.lbl_매수발생);
            this.groupBox4.Controls.Add(this.lbl_매도컬러);
            this.groupBox4.Controls.Add(this.lbl_매수컬러);
            this.groupBox4.Controls.Add(this.chk_자동매수);
            this.groupBox4.Controls.Add(this.lbl_매도신호);
            this.groupBox4.Controls.Add(this.lbl_매수신호);
            this.groupBox4.Controls.Add(this.btn_매도설정);
            this.groupBox4.Controls.Add(this.btn_매수설정);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.dtp_종료시간);
            this.groupBox4.Controls.Add(this.dtp_시작시간);
            this.groupBox4.Controls.Add(this.btn_자동주문);
            this.groupBox4.Controls.Add(this.lbl_영역좌표);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.lbl_영역크기);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.btn_인식영역선택);
            this.groupBox4.Location = new System.Drawing.Point(511, 14);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(341, 476);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "차트인식 자동주문";
            // 
            // lbl_크기확인
            // 
            this.lbl_크기확인.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_크기확인.Location = new System.Drawing.Point(290, 358);
            this.lbl_크기확인.Name = "lbl_크기확인";
            this.lbl_크기확인.Size = new System.Drawing.Size(25, 10);
            this.lbl_크기확인.TabIndex = 47;
            // 
            // chk_몸통크기
            // 
            this.chk_몸통크기.AutoSize = true;
            this.chk_몸통크기.Enabled = false;
            this.chk_몸통크기.Location = new System.Drawing.Point(126, 357);
            this.chk_몸통크기.Name = "chk_몸통크기";
            this.chk_몸통크기.Size = new System.Drawing.Size(96, 16);
            this.chk_몸통크기.TabIndex = 46;
            this.chk_몸통크기.Text = "차트몸통인식";
            this.chk_몸통크기.UseVisualStyleBackColor = true;
            this.chk_몸통크기.CheckedChanged += new System.EventHandler(this.chk_몸통크기_CheckedChanged);
            // 
            // nud_몸통크기
            // 
            this.nud_몸통크기.Enabled = false;
            this.nud_몸통크기.Location = new System.Drawing.Point(225, 356);
            this.nud_몸통크기.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nud_몸통크기.Name = "nud_몸통크기";
            this.nud_몸통크기.Size = new System.Drawing.Size(58, 21);
            this.nud_몸통크기.TabIndex = 45;
            this.nud_몸통크기.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_몸통크기.ValueChanged += new System.EventHandler(this.nud_몸통크기_ValueChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(11, 234);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 198);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 44;
            this.pictureBox2.TabStop = false;
            // 
            // btn_일괄취소
            // 
            this.btn_일괄취소.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_일괄취소.Location = new System.Drawing.Point(211, 388);
            this.btn_일괄취소.Name = "btn_일괄취소";
            this.btn_일괄취소.Size = new System.Drawing.Size(91, 27);
            this.btn_일괄취소.TabIndex = 43;
            this.btn_일괄취소.Text = "일괄취소(F6)";
            this.btn_일괄취소.UseVisualStyleBackColor = true;
            this.btn_일괄취소.Click += new System.EventHandler(this.btn_일괄취소_Click);
            // 
            // lbl_진입중
            // 
            this.lbl_진입중.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_진입중.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_진입중.Location = new System.Drawing.Point(128, 388);
            this.lbl_진입중.Name = "lbl_진입중";
            this.lbl_진입중.Size = new System.Drawing.Size(82, 27);
            this.lbl_진입중.TabIndex = 42;
            this.lbl_진입중.Text = "진입중";
            this.lbl_진입중.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_진입중.Visible = false;
            // 
            // lbl_현재시간
            // 
            this.lbl_현재시간.BackColor = System.Drawing.Color.White;
            this.lbl_현재시간.Location = new System.Drawing.Point(88, 158);
            this.lbl_현재시간.Name = "lbl_현재시간";
            this.lbl_현재시간.Size = new System.Drawing.Size(177, 16);
            this.lbl_현재시간.TabIndex = 41;
            this.lbl_현재시간.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_작동중타이틀
            // 
            this.lbl_작동중타이틀.AutoSize = true;
            this.lbl_작동중타이틀.Location = new System.Drawing.Point(31, 160);
            this.lbl_작동중타이틀.Name = "lbl_작동중타이틀";
            this.lbl_작동중타이틀.Size = new System.Drawing.Size(53, 12);
            this.lbl_작동중타이틀.TabIndex = 40;
            this.lbl_작동중타이틀.Text = "현재시간";
            // 
            // chk_자동스위칭
            // 
            this.chk_자동스위칭.AutoSize = true;
            this.chk_자동스위칭.Enabled = false;
            this.chk_자동스위칭.Location = new System.Drawing.Point(126, 330);
            this.chk_자동스위칭.Name = "chk_자동스위칭";
            this.chk_자동스위칭.Size = new System.Drawing.Size(164, 16);
            this.chk_자동스위칭.TabIndex = 39;
            this.chk_자동스위칭.Text = "포지션 보유중이면 스위칭";
            this.chk_자동스위칭.UseVisualStyleBackColor = true;
            this.chk_자동스위칭.CheckedChanged += new System.EventHandler(this.chk_자동스위칭_CheckedChanged);
            // 
            // chk_자동매도
            // 
            this.chk_자동매도.AutoSize = true;
            this.chk_자동매도.Enabled = false;
            this.chk_자동매도.Location = new System.Drawing.Point(197, 280);
            this.chk_자동매도.Name = "chk_자동매도";
            this.chk_자동매도.Size = new System.Drawing.Size(124, 16);
            this.chk_자동매도.TabIndex = 38;
            this.chk_자동매도.Text = "자동매도주문 사용";
            this.chk_자동매도.UseVisualStyleBackColor = true;
            this.chk_자동매도.CheckedChanged += new System.EventHandler(this.chk_자동매도_CheckedChanged);
            // 
            // lbl_매도발생
            // 
            this.lbl_매도발생.BackColor = System.Drawing.Color.SteelBlue;
            this.lbl_매도발생.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_매도발생.Location = new System.Drawing.Point(114, 418);
            this.lbl_매도발생.Name = "lbl_매도발생";
            this.lbl_매도발생.Size = new System.Drawing.Size(96, 44);
            this.lbl_매도발생.TabIndex = 37;
            this.lbl_매도발생.Text = "매도신호\r\n발생";
            this.lbl_매도발생.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_매도발생.Visible = false;
            // 
            // lbl_매수발생
            // 
            this.lbl_매수발생.BackColor = System.Drawing.Color.Coral;
            this.lbl_매수발생.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_매수발생.Location = new System.Drawing.Point(216, 418);
            this.lbl_매수발생.Name = "lbl_매수발생";
            this.lbl_매수발생.Size = new System.Drawing.Size(96, 44);
            this.lbl_매수발생.TabIndex = 36;
            this.lbl_매수발생.Text = "매수신호\r\n발생";
            this.lbl_매수발생.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_매수발생.Visible = false;
            // 
            // lbl_매도컬러
            // 
            this.lbl_매도컬러.BackColor = System.Drawing.Color.White;
            this.lbl_매도컬러.Location = new System.Drawing.Point(105, 299);
            this.lbl_매도컬러.Name = "lbl_매도컬러";
            this.lbl_매도컬러.Size = new System.Drawing.Size(20, 18);
            this.lbl_매도컬러.TabIndex = 35;
            // 
            // lbl_매수컬러
            // 
            this.lbl_매수컬러.BackColor = System.Drawing.Color.White;
            this.lbl_매수컬러.Location = new System.Drawing.Point(105, 248);
            this.lbl_매수컬러.Name = "lbl_매수컬러";
            this.lbl_매수컬러.Size = new System.Drawing.Size(20, 18);
            this.lbl_매수컬러.TabIndex = 34;
            // 
            // chk_자동매수
            // 
            this.chk_자동매수.AutoSize = true;
            this.chk_자동매수.Enabled = false;
            this.chk_자동매수.Location = new System.Drawing.Point(198, 230);
            this.chk_자동매수.Name = "chk_자동매수";
            this.chk_자동매수.Size = new System.Drawing.Size(124, 16);
            this.chk_자동매수.TabIndex = 33;
            this.chk_자동매수.Text = "자동매수주문 사용";
            this.chk_자동매수.UseVisualStyleBackColor = true;
            this.chk_자동매수.CheckedChanged += new System.EventHandler(this.chk_자동주문_CheckedChanged);
            // 
            // lbl_매도신호
            // 
            this.lbl_매도신호.BackColor = System.Drawing.Color.White;
            this.lbl_매도신호.Location = new System.Drawing.Point(126, 299);
            this.lbl_매도신호.Name = "lbl_매도신호";
            this.lbl_매도신호.Size = new System.Drawing.Size(158, 18);
            this.lbl_매도신호.TabIndex = 32;
            this.lbl_매도신호.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_매수신호
            // 
            this.lbl_매수신호.BackColor = System.Drawing.Color.White;
            this.lbl_매수신호.Location = new System.Drawing.Point(126, 248);
            this.lbl_매수신호.Name = "lbl_매수신호";
            this.lbl_매수신호.Size = new System.Drawing.Size(158, 18);
            this.lbl_매수신호.TabIndex = 31;
            this.lbl_매수신호.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_매도설정
            // 
            this.btn_매도설정.Location = new System.Drawing.Point(290, 296);
            this.btn_매도설정.Name = "btn_매도설정";
            this.btn_매도설정.Size = new System.Drawing.Size(37, 25);
            this.btn_매도설정.TabIndex = 30;
            this.btn_매도설정.Text = "설정";
            this.btn_매도설정.UseVisualStyleBackColor = true;
            this.btn_매도설정.Click += new System.EventHandler(this.btn_매도설정_Click);
            // 
            // btn_매수설정
            // 
            this.btn_매수설정.Location = new System.Drawing.Point(290, 246);
            this.btn_매수설정.Name = "btn_매수설정";
            this.btn_매수설정.Size = new System.Drawing.Size(37, 25);
            this.btn_매수설정.TabIndex = 29;
            this.btn_매수설정.Text = "설정";
            this.btn_매수설정.UseVisualStyleBackColor = true;
            this.btn_매수설정.Click += new System.EventHandler(this.btn_매수설정_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(105, 281);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 12);
            this.label11.TabIndex = 28;
            this.label11.Text = "매도신호인식";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(105, 231);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 12);
            this.label10.TabIndex = 27;
            this.label10.Text = "매수신호인식";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(51, 234);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(172, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 24;
            this.label8.Text = "종료시간";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 23;
            this.label7.Text = "시작시간";
            // 
            // dtp_종료시간
            // 
            this.dtp_종료시간.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtp_종료시간.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_종료시간.Location = new System.Drawing.Point(171, 126);
            this.dtp_종료시간.Name = "dtp_종료시간";
            this.dtp_종료시간.Size = new System.Drawing.Size(161, 21);
            this.dtp_종료시간.TabIndex = 22;
            // 
            // dtp_시작시간
            // 
            this.dtp_시작시간.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtp_시작시간.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_시작시간.Location = new System.Drawing.Point(8, 126);
            this.dtp_시작시간.Name = "dtp_시작시간";
            this.dtp_시작시간.Size = new System.Drawing.Size(157, 21);
            this.dtp_시작시간.TabIndex = 21;
            // 
            // btn_자동주문
            // 
            this.btn_자동주문.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_자동주문.Location = new System.Drawing.Point(33, 177);
            this.btn_자동주문.Name = "btn_자동주문";
            this.btn_자동주문.Size = new System.Drawing.Size(212, 43);
            this.btn_자동주문.TabIndex = 20;
            this.btn_자동주문.Text = "작동시작";
            this.btn_자동주문.UseVisualStyleBackColor = true;
            this.btn_자동주문.Click += new System.EventHandler(this.btn_자동주문_Click);
            // 
            // lbl_영역좌표
            // 
            this.lbl_영역좌표.BackColor = System.Drawing.Color.White;
            this.lbl_영역좌표.Location = new System.Drawing.Point(173, 72);
            this.lbl_영역좌표.Name = "lbl_영역좌표";
            this.lbl_영역좌표.Size = new System.Drawing.Size(159, 20);
            this.lbl_영역좌표.TabIndex = 19;
            this.lbl_영역좌표.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(170, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 18;
            this.label6.Text = "영역좌표";
            // 
            // lbl_영역크기
            // 
            this.lbl_영역크기.BackColor = System.Drawing.Color.White;
            this.lbl_영역크기.Location = new System.Drawing.Point(6, 72);
            this.lbl_영역크기.Name = "lbl_영역크기";
            this.lbl_영역크기.Size = new System.Drawing.Size(159, 20);
            this.lbl_영역크기.TabIndex = 17;
            this.lbl_영역크기.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "영역크기";
            // 
            // btn_인식영역선택
            // 
            this.btn_인식영역선택.Location = new System.Drawing.Point(6, 20);
            this.btn_인식영역선택.Name = "btn_인식영역선택";
            this.btn_인식영역선택.Size = new System.Drawing.Size(329, 27);
            this.btn_인식영역선택.TabIndex = 3;
            this.btn_인식영역선택.Text = "인식영역 선택";
            this.btn_인식영역선택.UseVisualStyleBackColor = true;
            this.btn_인식영역선택.Click += new System.EventHandler(this.btn_인식영역선택_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lbl_1픽셀은);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.lbl_1포인트는);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.nud_포인트값);
            this.groupBox5.Controls.Add(this.lbl_봉크기);
            this.groupBox5.Controls.Add(this.lbl_몸통크기);
            this.groupBox5.Controls.Add(this.btn_몸통확인);
            this.groupBox5.Location = new System.Drawing.Point(147, 402);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(352, 87);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "봉크기로 포인트 계산";
            // 
            // lbl_1픽셀은
            // 
            this.lbl_1픽셀은.Location = new System.Drawing.Point(270, 73);
            this.lbl_1픽셀은.Name = "lbl_1픽셀은";
            this.lbl_1픽셀은.Size = new System.Drawing.Size(72, 10);
            this.lbl_1픽셀은.TabIndex = 55;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(253, 55);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 12);
            this.label15.TabIndex = 54;
            this.label15.Text = "1픽셀 =";
            // 
            // lbl_1포인트는
            // 
            this.lbl_1포인트는.Location = new System.Drawing.Point(269, 38);
            this.lbl_1포인트는.Name = "lbl_1포인트는";
            this.lbl_1포인트는.Size = new System.Drawing.Size(72, 10);
            this.lbl_1포인트는.TabIndex = 53;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(252, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 12);
            this.label12.TabIndex = 52;
            this.label12.Text = "1포인트 =";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(156, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 12);
            this.label9.TabIndex = 51;
            this.label9.Text = "포인트값 입력";
            // 
            // nud_포인트값
            // 
            this.nud_포인트값.DecimalPlaces = 2;
            this.nud_포인트값.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nud_포인트값.Location = new System.Drawing.Point(158, 53);
            this.nud_포인트값.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nud_포인트값.Name = "nud_포인트값";
            this.nud_포인트값.Size = new System.Drawing.Size(73, 21);
            this.nud_포인트값.TabIndex = 50;
            this.nud_포인트값.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nud_포인트값.ValueChanged += new System.EventHandler(this.nud_포인트값_ValueChanged);
            // 
            // lbl_봉크기
            // 
            this.lbl_봉크기.AutoSize = true;
            this.lbl_봉크기.Location = new System.Drawing.Point(12, 62);
            this.lbl_봉크기.Name = "lbl_봉크기";
            this.lbl_봉크기.Size = new System.Drawing.Size(0, 12);
            this.lbl_봉크기.TabIndex = 49;
            // 
            // lbl_몸통크기
            // 
            this.lbl_몸통크기.BackColor = System.Drawing.Color.Coral;
            this.lbl_몸통크기.Location = new System.Drawing.Point(125, 20);
            this.lbl_몸통크기.Name = "lbl_몸통크기";
            this.lbl_몸통크기.Size = new System.Drawing.Size(25, 0);
            this.lbl_몸통크기.TabIndex = 48;
            // 
            // btn_몸통확인
            // 
            this.btn_몸통확인.Location = new System.Drawing.Point(6, 20);
            this.btn_몸통확인.Name = "btn_몸통확인";
            this.btn_몸통확인.Size = new System.Drawing.Size(112, 27);
            this.btn_몸통확인.TabIndex = 4;
            this.btn_몸통확인.Text = "1번봉 크기확인";
            this.btn_몸통확인.UseVisualStyleBackColor = true;
            this.btn_몸통확인.Click += new System.EventHandler(this.btn_몸통확인_Click);
            // 
            // btn_테스트작동
            // 
            this.btn_테스트작동.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_테스트작동.Location = new System.Drawing.Point(255, 177);
            this.btn_테스트작동.Name = "btn_테스트작동";
            this.btn_테스트작동.Size = new System.Drawing.Size(86, 43);
            this.btn_테스트작동.TabIndex = 48;
            this.btn_테스트작동.Text = "test작동";
            this.btn_테스트작동.UseVisualStyleBackColor = true;
            this.btn_테스트작동.Click += new System.EventHandler(this.btn_테스트작동_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 494);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(850, 450);
            this.Name = "Form1";
            this.Text = "신호인식자동매매_Test_1.0.2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_몸통크기)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_포인트값)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_매수;
        private System.Windows.Forms.Button btn_청산;
        private System.Windows.Forms.Button btn_매도;
        private System.Windows.Forms.Button btn_매수스위칭;
        private System.Windows.Forms.Button btn_매도스위칭;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lbl_handle_계약수;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_평가손익;
        private System.Windows.Forms.Label lbl_진입단가;
        private System.Windows.Forms.Label lbl_수량;
        private System.Windows.Forms.Label lbl_포지션;
        private System.Windows.Forms.Label lbl_handle_평가손익;
        private System.Windows.Forms.Label lbl_handle_진입단가;
        private System.Windows.Forms.Label lbl_handle_수량;
        private System.Windows.Forms.Label lbl_handle_포지션;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chk_자동매수;
        private System.Windows.Forms.Label lbl_매도신호;
        private System.Windows.Forms.Label lbl_매수신호;
        private System.Windows.Forms.Button btn_매도설정;
        private System.Windows.Forms.Button btn_매수설정;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_종료시간;
        private System.Windows.Forms.DateTimePicker dtp_시작시간;
        private System.Windows.Forms.Button btn_자동주문;
        private System.Windows.Forms.Label lbl_영역좌표;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_영역크기;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_인식영역선택;
        private System.Windows.Forms.Label lbl_매수컬러;
        private System.Windows.Forms.Label lbl_매도컬러;
        private System.Windows.Forms.Label lbl_매도발생;
        private System.Windows.Forms.Label lbl_매수발생;
        private System.Windows.Forms.CheckBox chk_자동스위칭;
        private System.Windows.Forms.CheckBox chk_자동매도;
        private System.Windows.Forms.Label lbl_현재시간;
        private System.Windows.Forms.Label lbl_작동중타이틀;
        private System.Windows.Forms.Button btn_일괄취소;
        private System.Windows.Forms.Label lbl_진입중;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_크기확인;
        private System.Windows.Forms.CheckBox chk_몸통크기;
        private System.Windows.Forms.NumericUpDown nud_몸통크기;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lbl_1픽셀은;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbl_1포인트는;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nud_포인트값;
        private System.Windows.Forms.Label lbl_봉크기;
        private System.Windows.Forms.Label lbl_몸통크기;
        private System.Windows.Forms.Button btn_몸통확인;
        private System.Windows.Forms.Button btn_테스트작동;
    }
}


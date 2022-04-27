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
            this.btn_인식영역선택 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_영역크기 = new System.Windows.Forms.Label();
            this.lbl_영역좌표 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_자동주문 = new System.Windows.Forms.Button();
            this.dtp_시작시간 = new System.Windows.Forms.DateTimePicker();
            this.dtp_종료시간 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_매수설정 = new System.Windows.Forms.Button();
            this.btn_매도설정 = new System.Windows.Forms.Button();
            this.lbl_매수신호 = new System.Windows.Forms.Label();
            this.lbl_매도신호 = new System.Windows.Forms.Label();
            this.chk_자동주문 = new System.Windows.Forms.CheckBox();
            this.lbl_매수컬러 = new System.Windows.Forms.Label();
            this.lbl_매도컬러 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.lbl_handle_평가손익.Location = new System.Drawing.Point(329, 76);
            this.lbl_handle_평가손익.Name = "lbl_handle_평가손익";
            this.lbl_handle_평가손익.Size = new System.Drawing.Size(100, 13);
            this.lbl_handle_평가손익.TabIndex = 19;
            // 
            // lbl_handle_진입단가
            // 
            this.lbl_handle_진입단가.BackColor = System.Drawing.Color.White;
            this.lbl_handle_진입단가.Location = new System.Drawing.Point(223, 76);
            this.lbl_handle_진입단가.Name = "lbl_handle_진입단가";
            this.lbl_handle_진입단가.Size = new System.Drawing.Size(100, 13);
            this.lbl_handle_진입단가.TabIndex = 18;
            // 
            // lbl_handle_수량
            // 
            this.lbl_handle_수량.BackColor = System.Drawing.Color.White;
            this.lbl_handle_수량.Location = new System.Drawing.Point(117, 76);
            this.lbl_handle_수량.Name = "lbl_handle_수량";
            this.lbl_handle_수량.Size = new System.Drawing.Size(100, 13);
            this.lbl_handle_수량.TabIndex = 17;
            // 
            // lbl_handle_포지션
            // 
            this.lbl_handle_포지션.BackColor = System.Drawing.Color.White;
            this.lbl_handle_포지션.Location = new System.Drawing.Point(11, 76);
            this.lbl_handle_포지션.Name = "lbl_handle_포지션";
            this.lbl_handle_포지션.Size = new System.Drawing.Size(100, 13);
            this.lbl_handle_포지션.TabIndex = 16;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_평가손익);
            this.groupBox3.Controls.Add(this.lbl_진입단가);
            this.groupBox3.Controls.Add(this.lbl_수량);
            this.groupBox3.Controls.Add(this.lbl_포지션);
            this.groupBox3.Location = new System.Drawing.Point(13, 92);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(448, 49);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "동기화";
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
            this.lbl_handle_계약수.Location = new System.Drawing.Point(115, 60);
            this.lbl_handle_계약수.Name = "lbl_handle_계약수";
            this.lbl_handle_계약수.Size = new System.Drawing.Size(100, 13);
            this.lbl_handle_계약수.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "계약수 EditBox";
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
            this.groupBox2.Size = new System.Drawing.Size(475, 222);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "제어 테스트";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "기준계약수";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.numericUpDown1.Location = new System.Drawing.Point(184, 38);
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
            // 
            // btn_매수스위칭
            // 
            this.btn_매수스위칭.Location = new System.Drawing.Point(323, 130);
            this.btn_매수스위칭.Name = "btn_매수스위칭";
            this.btn_매수스위칭.Size = new System.Drawing.Size(133, 77);
            this.btn_매수스위칭.TabIndex = 4;
            this.btn_매수스위칭.Text = "매수스위칭\r\n(매도일 때)";
            this.btn_매수스위칭.UseVisualStyleBackColor = true;
            this.btn_매수스위칭.Click += new System.EventHandler(this.btn_매수스위칭_Click);
            // 
            // btn_매도스위칭
            // 
            this.btn_매도스위칭.Location = new System.Drawing.Point(13, 130);
            this.btn_매도스위칭.Name = "btn_매도스위칭";
            this.btn_매도스위칭.Size = new System.Drawing.Size(133, 77);
            this.btn_매도스위칭.TabIndex = 3;
            this.btn_매도스위칭.Text = "매도스위칭\r\n(매수일 때)";
            this.btn_매도스위칭.UseVisualStyleBackColor = true;
            this.btn_매도스위칭.Click += new System.EventHandler(this.btn_매도스위칭_Click);
            // 
            // btn_매수
            // 
            this.btn_매수.Location = new System.Drawing.Point(323, 38);
            this.btn_매수.Name = "btn_매수";
            this.btn_매수.Size = new System.Drawing.Size(133, 77);
            this.btn_매수.TabIndex = 2;
            this.btn_매수.Text = "시장가매수";
            this.btn_매수.UseVisualStyleBackColor = true;
            this.btn_매수.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_청산
            // 
            this.btn_청산.Location = new System.Drawing.Point(167, 82);
            this.btn_청산.Name = "btn_청산";
            this.btn_청산.Size = new System.Drawing.Size(133, 77);
            this.btn_청산.TabIndex = 1;
            this.btn_청산.Text = "일괄청산";
            this.btn_청산.UseVisualStyleBackColor = true;
            this.btn_청산.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_매도
            // 
            this.btn_매도.Location = new System.Drawing.Point(13, 38);
            this.btn_매도.Name = "btn_매도";
            this.btn_매도.Size = new System.Drawing.Size(133, 77);
            this.btn_매도.TabIndex = 0;
            this.btn_매도.Text = "시장가매도";
            this.btn_매도.UseVisualStyleBackColor = true;
            this.btn_매도.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbl_매도컬러);
            this.groupBox4.Controls.Add(this.lbl_매수컬러);
            this.groupBox4.Controls.Add(this.chk_자동주문);
            this.groupBox4.Controls.Add(this.lbl_매도신호);
            this.groupBox4.Controls.Add(this.lbl_매수신호);
            this.groupBox4.Controls.Add(this.btn_매도설정);
            this.groupBox4.Controls.Add(this.btn_매수설정);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
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
            this.groupBox4.Size = new System.Drawing.Size(308, 380);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "차트인식 자동주문";
            // 
            // btn_인식영역선택
            // 
            this.btn_인식영역선택.Location = new System.Drawing.Point(6, 20);
            this.btn_인식영역선택.Name = "btn_인식영역선택";
            this.btn_인식영역선택.Size = new System.Drawing.Size(295, 27);
            this.btn_인식영역선택.TabIndex = 3;
            this.btn_인식영역선택.Text = "인식영역 선택";
            this.btn_인식영역선택.UseVisualStyleBackColor = true;
            this.btn_인식영역선택.Click += new System.EventHandler(this.btn_인식영역선택_Click);
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
            // lbl_영역크기
            // 
            this.lbl_영역크기.BackColor = System.Drawing.Color.White;
            this.lbl_영역크기.Location = new System.Drawing.Point(6, 76);
            this.lbl_영역크기.Name = "lbl_영역크기";
            this.lbl_영역크기.Size = new System.Drawing.Size(140, 21);
            this.lbl_영역크기.TabIndex = 17;
            // 
            // lbl_영역좌표
            // 
            this.lbl_영역좌표.BackColor = System.Drawing.Color.White;
            this.lbl_영역좌표.Location = new System.Drawing.Point(161, 76);
            this.lbl_영역좌표.Name = "lbl_영역좌표";
            this.lbl_영역좌표.Size = new System.Drawing.Size(140, 21);
            this.lbl_영역좌표.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(161, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 18;
            this.label6.Text = "영역좌표";
            // 
            // btn_자동주문
            // 
            this.btn_자동주문.Location = new System.Drawing.Point(33, 159);
            this.btn_자동주문.Name = "btn_자동주문";
            this.btn_자동주문.Size = new System.Drawing.Size(244, 43);
            this.btn_자동주문.TabIndex = 20;
            this.btn_자동주문.Text = "작동시작";
            this.btn_자동주문.UseVisualStyleBackColor = true;
            this.btn_자동주문.Click += new System.EventHandler(this.btn_자동주문_Click);
            // 
            // dtp_시작시간
            // 
            this.dtp_시작시간.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtp_시작시간.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_시작시간.Location = new System.Drawing.Point(8, 126);
            this.dtp_시작시간.Name = "dtp_시작시간";
            this.dtp_시작시간.Size = new System.Drawing.Size(138, 21);
            this.dtp_시작시간.TabIndex = 21;
            // 
            // dtp_종료시간
            // 
            this.dtp_종료시간.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtp_종료시간.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_종료시간.Location = new System.Drawing.Point(163, 126);
            this.dtp_종료시간.Name = "dtp_종료시간";
            this.dtp_종료시간.Size = new System.Drawing.Size(138, 21);
            this.dtp_종료시간.TabIndex = 22;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(161, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 24;
            this.label8.Text = "종료시간";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(10, 230);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 149);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 26;
            this.label9.Text = "미리보기";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(93, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 27;
            this.label10.Text = "매수신호";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(93, 329);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 28;
            this.label11.Text = "매도신호";
            // 
            // btn_매수설정
            // 
            this.btn_매수설정.Location = new System.Drawing.Point(152, 266);
            this.btn_매수설정.Name = "btn_매수설정";
            this.btn_매수설정.Size = new System.Drawing.Size(37, 25);
            this.btn_매수설정.TabIndex = 29;
            this.btn_매수설정.Text = "설정";
            this.btn_매수설정.UseVisualStyleBackColor = true;
            this.btn_매수설정.Click += new System.EventHandler(this.btn_매수설정_Click);
            // 
            // btn_매도설정
            // 
            this.btn_매도설정.Location = new System.Drawing.Point(152, 323);
            this.btn_매도설정.Name = "btn_매도설정";
            this.btn_매도설정.Size = new System.Drawing.Size(37, 25);
            this.btn_매도설정.TabIndex = 30;
            this.btn_매도설정.Text = "설정";
            this.btn_매도설정.UseVisualStyleBackColor = true;
            this.btn_매도설정.Click += new System.EventHandler(this.btn_매도설정_Click);
            // 
            // lbl_매수신호
            // 
            this.lbl_매수신호.BackColor = System.Drawing.Color.White;
            this.lbl_매수신호.Location = new System.Drawing.Point(93, 295);
            this.lbl_매수신호.Name = "lbl_매수신호";
            this.lbl_매수신호.Size = new System.Drawing.Size(206, 25);
            this.lbl_매수신호.TabIndex = 31;
            // 
            // lbl_매도신호
            // 
            this.lbl_매도신호.BackColor = System.Drawing.Color.White;
            this.lbl_매도신호.Location = new System.Drawing.Point(93, 347);
            this.lbl_매도신호.Name = "lbl_매도신호";
            this.lbl_매도신호.Size = new System.Drawing.Size(206, 25);
            this.lbl_매도신호.TabIndex = 32;
            // 
            // chk_자동주문
            // 
            this.chk_자동주문.AutoSize = true;
            this.chk_자동주문.Location = new System.Drawing.Point(177, 204);
            this.chk_자동주문.Name = "chk_자동주문";
            this.chk_자동주문.Size = new System.Drawing.Size(100, 16);
            this.chk_자동주문.TabIndex = 33;
            this.chk_자동주문.Text = "자동주문 사용";
            this.chk_자동주문.UseVisualStyleBackColor = true;
            this.chk_자동주문.CheckedChanged += new System.EventHandler(this.chk_자동주문_CheckedChanged);
            // 
            // lbl_매수컬러
            // 
            this.lbl_매수컬러.BackColor = System.Drawing.Color.White;
            this.lbl_매수컬러.Location = new System.Drawing.Point(194, 265);
            this.lbl_매수컬러.Name = "lbl_매수컬러";
            this.lbl_매수컬러.Size = new System.Drawing.Size(28, 27);
            this.lbl_매수컬러.TabIndex = 34;
            // 
            // lbl_매도컬러
            // 
            this.lbl_매도컬러.BackColor = System.Drawing.Color.White;
            this.lbl_매도컬러.Location = new System.Drawing.Point(194, 323);
            this.lbl_매도컬러.Name = "lbl_매도컬러";
            this.lbl_매도컬러.Size = new System.Drawing.Size(28, 27);
            this.lbl_매도컬러.TabIndex = 35;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 407);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.CheckBox chk_자동주문;
        private System.Windows.Forms.Label lbl_매도신호;
        private System.Windows.Forms.Label lbl_매수신호;
        private System.Windows.Forms.Button btn_매도설정;
        private System.Windows.Forms.Button btn_매수설정;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
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
    }
}


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MAIN
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("PROGRAMMING TEST")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("SYSTEM ID", New System.Windows.Forms.TreeNode() {TreeNode1})
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("PROGRAMMING TEST")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("BATTERY ID", New System.Windows.Forms.TreeNode() {TreeNode3})
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("PROGRAMMING TEST")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("POWER TEST")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("SWITCH TEST")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("MODE TEST")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("TIME TEST")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("STEPPER TEST")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("SHUT DOWN")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("SMC", New System.Windows.Forms.TreeNode() {TreeNode5, TreeNode6, TreeNode7, TreeNode8, TreeNode9, TreeNode10, TreeNode11})
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("PROGRAMMING TEST")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("FUNCTIONAL TEST")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("TIME TEST")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("SHUT DOWN TEST")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("HPC", New System.Windows.Forms.TreeNode() {TreeNode13, TreeNode14, TreeNode15, TreeNode16})
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("UL SSMC")
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("PLUG POWER", New System.Windows.Forms.TreeNode() {TreeNode2, TreeNode4, TreeNode12, TreeNode17, TreeNode18})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MAIN))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FILEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOGINToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOGOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EDITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CREATEUSERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REMOVEUSERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CHANGEPASSWORDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UPDATEDESIGNATIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VIEWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FIRSTPASSYIELDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FINALPASSYIELDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ENABLEMANUALMODEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SETTINGSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfrigurationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SETUPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HELPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABOUTSOFTWAREToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.TextBox19 = New System.Windows.Forms.TextBox()
        Me.TextBox20 = New System.Windows.Forms.TextBox()
        Me.TextBox21 = New System.Windows.Forms.TextBox()
        Me.TextBox22 = New System.Windows.Forms.TextBox()
        Me.TextBox23 = New System.Windows.Forms.TextBox()
        Me.TextBox24 = New System.Windows.Forms.TextBox()
        Me.TextBox25 = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Button40 = New System.Windows.Forms.Button()
        Me.TextBox152 = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.TextBox38 = New System.Windows.Forms.TextBox()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.TextBox37 = New System.Windows.Forms.TextBox()
        Me.TextBox26 = New System.Windows.Forms.TextBox()
        Me.TextBox36 = New System.Windows.Forms.TextBox()
        Me.TextBox27 = New System.Windows.Forms.TextBox()
        Me.TextBox35 = New System.Windows.Forms.TextBox()
        Me.TextBox28 = New System.Windows.Forms.TextBox()
        Me.TextBox29 = New System.Windows.Forms.TextBox()
        Me.TextBox30 = New System.Windows.Forms.TextBox()
        Me.TextBox31 = New System.Windows.Forms.TextBox()
        Me.TextBox32 = New System.Windows.Forms.TextBox()
        Me.TextBox33 = New System.Windows.Forms.TextBox()
        Me.TextBox34 = New System.Windows.Forms.TextBox()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.Button25 = New System.Windows.Forms.Button()
        Me.TextBox75 = New System.Windows.Forms.TextBox()
        Me.Button24 = New System.Windows.Forms.Button()
        Me.TextBox74 = New System.Windows.Forms.TextBox()
        Me.TextBox68 = New System.Windows.Forms.TextBox()
        Me.TextBox73 = New System.Windows.Forms.TextBox()
        Me.TextBox69 = New System.Windows.Forms.TextBox()
        Me.TextBox72 = New System.Windows.Forms.TextBox()
        Me.TextBox70 = New System.Windows.Forms.TextBox()
        Me.TextBox71 = New System.Windows.Forms.TextBox()
        Me.Button23 = New System.Windows.Forms.Button()
        Me.TextBox67 = New System.Windows.Forms.TextBox()
        Me.Button22 = New System.Windows.Forms.Button()
        Me.TextBox63 = New System.Windows.Forms.TextBox()
        Me.Button21 = New System.Windows.Forms.Button()
        Me.TextBox59 = New System.Windows.Forms.TextBox()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.TextBox66 = New System.Windows.Forms.TextBox()
        Me.TextBox55 = New System.Windows.Forms.TextBox()
        Me.TextBox62 = New System.Windows.Forms.TextBox()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.TextBox58 = New System.Windows.Forms.TextBox()
        Me.TextBox39 = New System.Windows.Forms.TextBox()
        Me.TextBox65 = New System.Windows.Forms.TextBox()
        Me.TextBox54 = New System.Windows.Forms.TextBox()
        Me.TextBox61 = New System.Windows.Forms.TextBox()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.TextBox57 = New System.Windows.Forms.TextBox()
        Me.TextBox40 = New System.Windows.Forms.TextBox()
        Me.TextBox64 = New System.Windows.Forms.TextBox()
        Me.TextBox53 = New System.Windows.Forms.TextBox()
        Me.TextBox60 = New System.Windows.Forms.TextBox()
        Me.TextBox41 = New System.Windows.Forms.TextBox()
        Me.TextBox56 = New System.Windows.Forms.TextBox()
        Me.TextBox42 = New System.Windows.Forms.TextBox()
        Me.TextBox52 = New System.Windows.Forms.TextBox()
        Me.TextBox43 = New System.Windows.Forms.TextBox()
        Me.TextBox44 = New System.Windows.Forms.TextBox()
        Me.TextBox45 = New System.Windows.Forms.TextBox()
        Me.TextBox46 = New System.Windows.Forms.TextBox()
        Me.TextBox47 = New System.Windows.Forms.TextBox()
        Me.TextBox48 = New System.Windows.Forms.TextBox()
        Me.TextBox49 = New System.Windows.Forms.TextBox()
        Me.TextBox50 = New System.Windows.Forms.TextBox()
        Me.TextBox51 = New System.Windows.Forms.TextBox()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.Button36 = New System.Windows.Forms.Button()
        Me.TextBox124 = New System.Windows.Forms.TextBox()
        Me.Button35 = New System.Windows.Forms.Button()
        Me.TextBox120 = New System.Windows.Forms.TextBox()
        Me.Button34 = New System.Windows.Forms.Button()
        Me.TextBox116 = New System.Windows.Forms.TextBox()
        Me.Button33 = New System.Windows.Forms.Button()
        Me.TextBox112 = New System.Windows.Forms.TextBox()
        Me.Button32 = New System.Windows.Forms.Button()
        Me.TextBox108 = New System.Windows.Forms.TextBox()
        Me.TextBox123 = New System.Windows.Forms.TextBox()
        Me.Button31 = New System.Windows.Forms.Button()
        Me.TextBox119 = New System.Windows.Forms.TextBox()
        Me.TextBox104 = New System.Windows.Forms.TextBox()
        Me.TextBox115 = New System.Windows.Forms.TextBox()
        Me.Button30 = New System.Windows.Forms.Button()
        Me.TextBox111 = New System.Windows.Forms.TextBox()
        Me.TextBox100 = New System.Windows.Forms.TextBox()
        Me.TextBox107 = New System.Windows.Forms.TextBox()
        Me.TextBox122 = New System.Windows.Forms.TextBox()
        Me.Button29 = New System.Windows.Forms.Button()
        Me.TextBox118 = New System.Windows.Forms.TextBox()
        Me.TextBox103 = New System.Windows.Forms.TextBox()
        Me.TextBox114 = New System.Windows.Forms.TextBox()
        Me.TextBox96 = New System.Windows.Forms.TextBox()
        Me.TextBox110 = New System.Windows.Forms.TextBox()
        Me.TextBox99 = New System.Windows.Forms.TextBox()
        Me.TextBox106 = New System.Windows.Forms.TextBox()
        Me.TextBox121 = New System.Windows.Forms.TextBox()
        Me.Button28 = New System.Windows.Forms.Button()
        Me.TextBox117 = New System.Windows.Forms.TextBox()
        Me.TextBox102 = New System.Windows.Forms.TextBox()
        Me.TextBox113 = New System.Windows.Forms.TextBox()
        Me.TextBox95 = New System.Windows.Forms.TextBox()
        Me.TextBox109 = New System.Windows.Forms.TextBox()
        Me.TextBox98 = New System.Windows.Forms.TextBox()
        Me.TextBox105 = New System.Windows.Forms.TextBox()
        Me.TextBox89 = New System.Windows.Forms.TextBox()
        Me.TextBox101 = New System.Windows.Forms.TextBox()
        Me.TextBox94 = New System.Windows.Forms.TextBox()
        Me.TextBox97 = New System.Windows.Forms.TextBox()
        Me.TextBox90 = New System.Windows.Forms.TextBox()
        Me.TextBox93 = New System.Windows.Forms.TextBox()
        Me.TextBox91 = New System.Windows.Forms.TextBox()
        Me.TextBox92 = New System.Windows.Forms.TextBox()
        Me.Button27 = New System.Windows.Forms.Button()
        Me.TextBox85 = New System.Windows.Forms.TextBox()
        Me.TextBox86 = New System.Windows.Forms.TextBox()
        Me.TextBox87 = New System.Windows.Forms.TextBox()
        Me.TextBox88 = New System.Windows.Forms.TextBox()
        Me.Button26 = New System.Windows.Forms.Button()
        Me.TextBox81 = New System.Windows.Forms.TextBox()
        Me.TextBox82 = New System.Windows.Forms.TextBox()
        Me.TextBox83 = New System.Windows.Forms.TextBox()
        Me.TextBox84 = New System.Windows.Forms.TextBox()
        Me.TextBox76 = New System.Windows.Forms.TextBox()
        Me.TextBox77 = New System.Windows.Forms.TextBox()
        Me.TextBox78 = New System.Windows.Forms.TextBox()
        Me.TextBox79 = New System.Windows.Forms.TextBox()
        Me.TextBox80 = New System.Windows.Forms.TextBox()
        Me.TabPage10 = New System.Windows.Forms.TabPage()
        Me.Button37 = New System.Windows.Forms.Button()
        Me.TextBox125 = New System.Windows.Forms.TextBox()
        Me.TextBox126 = New System.Windows.Forms.TextBox()
        Me.TextBox127 = New System.Windows.Forms.TextBox()
        Me.TextBox128 = New System.Windows.Forms.TextBox()
        Me.TextBox129 = New System.Windows.Forms.TextBox()
        Me.TextBox130 = New System.Windows.Forms.TextBox()
        Me.TextBox131 = New System.Windows.Forms.TextBox()
        Me.TextBox132 = New System.Windows.Forms.TextBox()
        Me.TextBox133 = New System.Windows.Forms.TextBox()
        Me.TabPage11 = New System.Windows.Forms.TabPage()
        Me.Button38 = New System.Windows.Forms.Button()
        Me.TextBox134 = New System.Windows.Forms.TextBox()
        Me.TextBox135 = New System.Windows.Forms.TextBox()
        Me.TextBox136 = New System.Windows.Forms.TextBox()
        Me.TextBox137 = New System.Windows.Forms.TextBox()
        Me.TextBox138 = New System.Windows.Forms.TextBox()
        Me.TextBox139 = New System.Windows.Forms.TextBox()
        Me.TextBox140 = New System.Windows.Forms.TextBox()
        Me.TextBox141 = New System.Windows.Forms.TextBox()
        Me.TextBox142 = New System.Windows.Forms.TextBox()
        Me.TabPage12 = New System.Windows.Forms.TabPage()
        Me.Button39 = New System.Windows.Forms.Button()
        Me.TextBox143 = New System.Windows.Forms.TextBox()
        Me.TextBox144 = New System.Windows.Forms.TextBox()
        Me.TextBox145 = New System.Windows.Forms.TextBox()
        Me.TextBox146 = New System.Windows.Forms.TextBox()
        Me.TextBox147 = New System.Windows.Forms.TextBox()
        Me.TextBox148 = New System.Windows.Forms.TextBox()
        Me.TextBox149 = New System.Windows.Forms.TextBox()
        Me.TextBox150 = New System.Windows.Forms.TextBox()
        Me.TextBox151 = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.StartTimer3 = New System.Windows.Forms.RadioButton()
        Me.StopTimer = New System.Windows.Forms.RadioButton()
        Me.ResetTimer = New System.Windows.Forms.RadioButton()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl2.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        Me.TabPage10.SuspendLayout()
        Me.TabPage11.SuspendLayout()
        Me.TabPage12.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(568, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(279, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PLUG POWER FUNCTIONAL TEST"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Window
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILEToolStripMenuItem, Me.EDITToolStripMenuItem, Me.VIEWToolStripMenuItem, Me.SETTINGSToolStripMenuItem, Me.ABOUTToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1350, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FILEToolStripMenuItem
        '
        Me.FILEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LOGINToolStripMenuItem, Me.LOGOUTToolStripMenuItem, Me.EXITToolStripMenuItem})
        Me.FILEToolStripMenuItem.Name = "FILEToolStripMenuItem"
        Me.FILEToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.FILEToolStripMenuItem.Text = "FILE"
        '
        'LOGINToolStripMenuItem
        '
        Me.LOGINToolStripMenuItem.Image = Global.PLU_POWER_FCT.My.Resources.Resources.user
        Me.LOGINToolStripMenuItem.Name = "LOGINToolStripMenuItem"
        Me.LOGINToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.LOGINToolStripMenuItem.Text = "LOGIN"
        '
        'LOGOUTToolStripMenuItem
        '
        Me.LOGOUTToolStripMenuItem.Image = Global.PLU_POWER_FCT.My.Resources.Resources.logout
        Me.LOGOUTToolStripMenuItem.Name = "LOGOUTToolStripMenuItem"
        Me.LOGOUTToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.LOGOUTToolStripMenuItem.Text = "LOG OUT"
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.Image = Global.PLU_POWER_FCT.My.Resources.Resources.button
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.EXITToolStripMenuItem.Text = "EXIT"
        '
        'EDITToolStripMenuItem
        '
        Me.EDITToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CREATEUSERToolStripMenuItem, Me.REMOVEUSERToolStripMenuItem, Me.CHANGEPASSWORDToolStripMenuItem, Me.UPDATEDESIGNATIONToolStripMenuItem})
        Me.EDITToolStripMenuItem.Name = "EDITToolStripMenuItem"
        Me.EDITToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.EDITToolStripMenuItem.Text = "EDIT"
        '
        'CREATEUSERToolStripMenuItem
        '
        Me.CREATEUSERToolStripMenuItem.Image = Global.PLU_POWER_FCT.My.Resources.Resources.add_user
        Me.CREATEUSERToolStripMenuItem.Name = "CREATEUSERToolStripMenuItem"
        Me.CREATEUSERToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.CREATEUSERToolStripMenuItem.Text = "CREATE USER"
        '
        'REMOVEUSERToolStripMenuItem
        '
        Me.REMOVEUSERToolStripMenuItem.Image = Global.PLU_POWER_FCT.My.Resources.Resources.user_rem
        Me.REMOVEUSERToolStripMenuItem.Name = "REMOVEUSERToolStripMenuItem"
        Me.REMOVEUSERToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.REMOVEUSERToolStripMenuItem.Text = "REMOVE USER"
        '
        'CHANGEPASSWORDToolStripMenuItem
        '
        Me.CHANGEPASSWORDToolStripMenuItem.Image = Global.PLU_POWER_FCT.My.Resources.Resources.reset_password
        Me.CHANGEPASSWORDToolStripMenuItem.Name = "CHANGEPASSWORDToolStripMenuItem"
        Me.CHANGEPASSWORDToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.CHANGEPASSWORDToolStripMenuItem.Text = "CHANGE PASSWORD"
        '
        'UPDATEDESIGNATIONToolStripMenuItem
        '
        Me.UPDATEDESIGNATIONToolStripMenuItem.Image = Global.PLU_POWER_FCT.My.Resources.Resources.exchange
        Me.UPDATEDESIGNATIONToolStripMenuItem.Name = "UPDATEDESIGNATIONToolStripMenuItem"
        Me.UPDATEDESIGNATIONToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.UPDATEDESIGNATIONToolStripMenuItem.Text = "UPDATE DESIGNATION"
        '
        'VIEWToolStripMenuItem
        '
        Me.VIEWToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FIRSTPASSYIELDToolStripMenuItem, Me.FINALPASSYIELDToolStripMenuItem, Me.ENABLEMANUALMODEToolStripMenuItem})
        Me.VIEWToolStripMenuItem.Name = "VIEWToolStripMenuItem"
        Me.VIEWToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.VIEWToolStripMenuItem.Text = "VIEW"
        '
        'FIRSTPASSYIELDToolStripMenuItem
        '
        Me.FIRSTPASSYIELDToolStripMenuItem.Image = Global.PLU_POWER_FCT.My.Resources.Resources.yield
        Me.FIRSTPASSYIELDToolStripMenuItem.Name = "FIRSTPASSYIELDToolStripMenuItem"
        Me.FIRSTPASSYIELDToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.FIRSTPASSYIELDToolStripMenuItem.Text = "FIRST PASS YIELD"
        '
        'FINALPASSYIELDToolStripMenuItem
        '
        Me.FINALPASSYIELDToolStripMenuItem.Image = Global.PLU_POWER_FCT.My.Resources.Resources.yield_1
        Me.FINALPASSYIELDToolStripMenuItem.Name = "FINALPASSYIELDToolStripMenuItem"
        Me.FINALPASSYIELDToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.FINALPASSYIELDToolStripMenuItem.Text = "FINAL PASS YIELD"
        '
        'ENABLEMANUALMODEToolStripMenuItem
        '
        Me.ENABLEMANUALMODEToolStripMenuItem.Image = Global.PLU_POWER_FCT.My.Resources.Resources.enable
        Me.ENABLEMANUALMODEToolStripMenuItem.Name = "ENABLEMANUALMODEToolStripMenuItem"
        Me.ENABLEMANUALMODEToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.ENABLEMANUALMODEToolStripMenuItem.Text = "ENABLE MANUAL MODE"
        '
        'SETTINGSToolStripMenuItem
        '
        Me.SETTINGSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfrigurationsToolStripMenuItem, Me.SETUPToolStripMenuItem})
        Me.SETTINGSToolStripMenuItem.Name = "SETTINGSToolStripMenuItem"
        Me.SETTINGSToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.SETTINGSToolStripMenuItem.Text = "SETTINGS"
        '
        'ConfrigurationsToolStripMenuItem
        '
        Me.ConfrigurationsToolStripMenuItem.Image = Global.PLU_POWER_FCT.My.Resources.Resources.setting
        Me.ConfrigurationsToolStripMenuItem.Name = "ConfrigurationsToolStripMenuItem"
        Me.ConfrigurationsToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ConfrigurationsToolStripMenuItem.Text = "Confrigurations"
        '
        'SETUPToolStripMenuItem
        '
        Me.SETUPToolStripMenuItem.Image = Global.PLU_POWER_FCT.My.Resources.Resources.gear
        Me.SETUPToolStripMenuItem.Name = "SETUPToolStripMenuItem"
        Me.SETUPToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.SETUPToolStripMenuItem.Text = "SETUP"
        '
        'ABOUTToolStripMenuItem
        '
        Me.ABOUTToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HELPToolStripMenuItem, Me.ABOUTSOFTWAREToolStripMenuItem})
        Me.ABOUTToolStripMenuItem.Name = "ABOUTToolStripMenuItem"
        Me.ABOUTToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.ABOUTToolStripMenuItem.Text = "ABOUT"
        '
        'HELPToolStripMenuItem
        '
        Me.HELPToolStripMenuItem.Image = Global.PLU_POWER_FCT.My.Resources.Resources.question
        Me.HELPToolStripMenuItem.Name = "HELPToolStripMenuItem"
        Me.HELPToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.HELPToolStripMenuItem.Text = "HELP"
        '
        'ABOUTSOFTWAREToolStripMenuItem
        '
        Me.ABOUTSOFTWAREToolStripMenuItem.Image = Global.PLU_POWER_FCT.My.Resources.Resources.info
        Me.ABOUTSOFTWAREToolStripMenuItem.Name = "ABOUTSOFTWAREToolStripMenuItem"
        Me.ABOUTSOFTWAREToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.ABOUTSOFTWAREToolStripMenuItem.Text = "ABOUT SOFTWARE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1248, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Window
        Me.Label3.Font = New System.Drawing.Font("Bell MT", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(839, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 12)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "TEST STEP :"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Window
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.ProgressBar1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1349, 60)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(323, 35)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(111, 20)
        Me.TextBox5.TabIndex = 18
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(729, 35)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(102, 17)
        Me.RadioButton2.TabIndex = 17
        Me.RadioButton2.Text = "MANUALMODE"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(730, 12)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(87, 17)
        Me.RadioButton1.TabIndex = 16
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "AUTOMODE"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(323, 12)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(112, 20)
        Me.TextBox6.TabIndex = 15
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(233, 13)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 17)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "DUT ID :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(230, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 17)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "CYCLE TIME :"
        '
        'Button3
        '
        Me.Button3.AutoEllipsis = True
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(1216, 9)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(127, 24)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "START NEW TEST"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(834, 14)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(376, 39)
        Me.ProgressBar1.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.AutoEllipsis = True
        Me.Button1.BackColor = System.Drawing.SystemColors.Window
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(1216, 34)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 21)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "ABORT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(578, 36)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(133, 20)
        Me.TextBox3.TabIndex = 9
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(443, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(132, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "USER NAME AND ID :"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(578, 14)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(133, 20)
        Me.TextBox4.TabIndex = 9
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(443, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "SERIAL NUMBER :"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(109, 34)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(119, 20)
        Me.TextBox2.TabIndex = 5
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(109, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(119, 20)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "MODEL NAME :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TreeView1)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 86)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 374)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        '
        'TreeView1
        '
        Me.TreeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TreeView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TreeView1.HotTracking = True
        Me.TreeView1.Location = New System.Drawing.Point(6, 19)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "PROGRAMMING_TEST"
        TreeNode1.Text = "PROGRAMMING TEST"
        TreeNode2.Checked = True
        TreeNode2.Name = "SYSTEM_ID"
        TreeNode2.SelectedImageKey = "(default)"
        TreeNode2.Text = "SYSTEM ID"
        TreeNode3.Name = "PROGRAMMING_TEST"
        TreeNode3.Text = "PROGRAMMING TEST"
        TreeNode4.Name = "BATTERY_ID"
        TreeNode4.Text = "BATTERY ID"
        TreeNode5.Name = "PROGRAMMING_TEST"
        TreeNode5.Text = "PROGRAMMING TEST"
        TreeNode6.Name = "POWER_TEST"
        TreeNode6.Text = "POWER TEST"
        TreeNode7.Name = "SWITCH_TEST"
        TreeNode7.Text = "SWITCH TEST"
        TreeNode8.Name = "MODE_TEST"
        TreeNode8.Text = "MODE TEST"
        TreeNode9.Name = "TIME_TEST"
        TreeNode9.Text = "TIME TEST"
        TreeNode10.Name = "STEPPER_TEST"
        TreeNode10.Text = "STEPPER TEST"
        TreeNode11.Name = "SHUT_DOWN"
        TreeNode11.Text = "SHUT DOWN"
        TreeNode12.Name = "SMC"
        TreeNode12.Text = "SMC"
        TreeNode13.Name = "PROGRAMMING_TEST"
        TreeNode13.Text = "PROGRAMMING TEST"
        TreeNode14.Name = "FUNCTIONAL_TEST"
        TreeNode14.Text = "FUNCTIONAL TEST"
        TreeNode15.Name = "TIME_TEST"
        TreeNode15.Text = "TIME TEST"
        TreeNode16.Name = "SHUT_DOWN"
        TreeNode16.Text = "SHUT DOWN TEST"
        TreeNode17.Name = "HPC"
        TreeNode17.Text = "HPC"
        TreeNode18.Name = "UL_SSMC"
        TreeNode18.Text = "UL SSMC"
        TreeNode19.BackColor = System.Drawing.Color.White
        TreeNode19.Name = "PLUG_POWER"
        TreeNode19.NodeFont = New System.Drawing.Font("Bell MT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode19.Text = "PLUG POWER"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode19})
        Me.TreeView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TreeView1.Size = New System.Drawing.Size(186, 349)
        Me.TreeView1.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TabControl1)
        Me.GroupBox3.Location = New System.Drawing.Point(214, 86)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1124, 621)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Location = New System.Drawing.Point(11, 19)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(809, 591)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button11)
        Me.TabPage1.Controls.Add(Me.Button10)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Button9)
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.Button8)
        Me.TabPage1.Controls.Add(Me.TextBox14)
        Me.TabPage1.Controls.Add(Me.TextBox13)
        Me.TabPage1.Controls.Add(Me.TextBox12)
        Me.TabPage1.Controls.Add(Me.TextBox11)
        Me.TabPage1.Controls.Add(Me.TextBox10)
        Me.TabPage1.Controls.Add(Me.TextBox9)
        Me.TabPage1.Controls.Add(Me.TextBox8)
        Me.TabPage1.Controls.Add(Me.TextBox7)
        Me.TabPage1.Controls.Add(Me.TextBox15)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(801, 565)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "SYSTEM ID"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.Red
        Me.Button11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button11.Location = New System.Drawing.Point(7, 506)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(276, 53)
        Me.Button11.TabIndex = 24
        Me.Button11.Text = "NON-CONFIRM"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.Lime
        Me.Button10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button10.Location = New System.Drawing.Point(503, 506)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(276, 53)
        Me.Button10.TabIndex = 24
        Me.Button10.Text = "CONFIRM"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.Window
        Me.Label13.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(246, 484)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(260, 19)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "CONNECT THE DUT AS SHOWN"
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Lime
        Me.Button9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button9.Location = New System.Drawing.Point(7, 506)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(772, 53)
        Me.Button9.TabIndex = 22
        Me.Button9.Text = "CONNECTED"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(4, 78)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(766, 403)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(624, 42)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(146, 23)
        Me.Button8.TabIndex = 20
        Me.Button8.UseVisualStyleBackColor = True
        '
        'TextBox14
        '
        Me.TextBox14.Location = New System.Drawing.Point(472, 44)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(146, 20)
        Me.TextBox14.TabIndex = 19
        Me.TextBox14.Text = "TRUE"
        Me.TextBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(311, 44)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(146, 20)
        Me.TextBox13.TabIndex = 18
        Me.TextBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(159, 44)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(146, 20)
        Me.TextBox12.TabIndex = 17
        Me.TextBox12.Text = "TRUE"
        Me.TextBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(6, 44)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(147, 20)
        Me.TextBox11.TabIndex = 16
        Me.TextBox11.Text = "PROGRAMMING TEST"
        Me.TextBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(624, 7)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(146, 20)
        Me.TextBox10.TabIndex = 15
        Me.TextBox10.Text = "TEST STATUS"
        Me.TextBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(468, 5)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(150, 20)
        Me.TextBox9.TabIndex = 14
        Me.TextBox9.Text = "LOW LIMIT"
        Me.TextBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(311, 6)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(146, 20)
        Me.TextBox8.TabIndex = 13
        Me.TextBox8.Text = "MEASURED"
        Me.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(159, 6)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(146, 20)
        Me.TextBox7.TabIndex = 12
        Me.TextBox7.Text = "HIGH LIMIT"
        Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox15
        '
        Me.TextBox15.Location = New System.Drawing.Point(6, 6)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(147, 20)
        Me.TextBox15.TabIndex = 11
        Me.TextBox15.Text = "PARAMETER"
        Me.TextBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button13)
        Me.TabPage2.Controls.Add(Me.Button14)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.Button15)
        Me.TabPage2.Controls.Add(Me.PictureBox2)
        Me.TabPage2.Controls.Add(Me.Button12)
        Me.TabPage2.Controls.Add(Me.TextBox17)
        Me.TabPage2.Controls.Add(Me.TextBox18)
        Me.TabPage2.Controls.Add(Me.TextBox19)
        Me.TabPage2.Controls.Add(Me.TextBox20)
        Me.TabPage2.Controls.Add(Me.TextBox21)
        Me.TabPage2.Controls.Add(Me.TextBox22)
        Me.TabPage2.Controls.Add(Me.TextBox23)
        Me.TabPage2.Controls.Add(Me.TextBox24)
        Me.TabPage2.Controls.Add(Me.TextBox25)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(801, 565)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "BATTERY ID"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.Red
        Me.Button13.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button13.Location = New System.Drawing.Point(9, 506)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(276, 53)
        Me.Button13.TabIndex = 34
        Me.Button13.Text = "NON-CONFIRM"
        Me.Button13.UseVisualStyleBackColor = False
        '
        'Button14
        '
        Me.Button14.BackColor = System.Drawing.Color.Lime
        Me.Button14.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button14.Location = New System.Drawing.Point(505, 506)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(276, 53)
        Me.Button14.TabIndex = 35
        Me.Button14.Text = "CONFIRM"
        Me.Button14.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.SystemColors.Window
        Me.Label15.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(248, 486)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(260, 19)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "CONNECT THE DUT AS SHOWN"
        '
        'Button15
        '
        Me.Button15.BackColor = System.Drawing.Color.Lime
        Me.Button15.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button15.Location = New System.Drawing.Point(9, 506)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(772, 53)
        Me.Button15.TabIndex = 32
        Me.Button15.Text = "CONNECTED"
        Me.Button15.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(9, 81)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(766, 403)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 31
        Me.PictureBox2.TabStop = False
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(625, 42)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(146, 23)
        Me.Button12.TabIndex = 30
        Me.Button12.UseVisualStyleBackColor = True
        '
        'TextBox17
        '
        Me.TextBox17.Location = New System.Drawing.Point(473, 44)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(146, 20)
        Me.TextBox17.TabIndex = 29
        Me.TextBox17.Text = "TRUE"
        Me.TextBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox18
        '
        Me.TextBox18.Location = New System.Drawing.Point(312, 44)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(146, 20)
        Me.TextBox18.TabIndex = 28
        Me.TextBox18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox19
        '
        Me.TextBox19.Location = New System.Drawing.Point(160, 44)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(146, 20)
        Me.TextBox19.TabIndex = 27
        Me.TextBox19.Text = "TRUE"
        Me.TextBox19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox20
        '
        Me.TextBox20.Location = New System.Drawing.Point(7, 44)
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New System.Drawing.Size(147, 20)
        Me.TextBox20.TabIndex = 26
        Me.TextBox20.Text = "PROGRAMMING TEST"
        Me.TextBox20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox21
        '
        Me.TextBox21.Location = New System.Drawing.Point(625, 7)
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New System.Drawing.Size(146, 20)
        Me.TextBox21.TabIndex = 25
        Me.TextBox21.Text = "TEST STATUS"
        Me.TextBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox22
        '
        Me.TextBox22.Location = New System.Drawing.Point(469, 5)
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New System.Drawing.Size(150, 20)
        Me.TextBox22.TabIndex = 24
        Me.TextBox22.Text = "LOW LIMIT"
        Me.TextBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox23
        '
        Me.TextBox23.Location = New System.Drawing.Point(312, 6)
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New System.Drawing.Size(146, 20)
        Me.TextBox23.TabIndex = 23
        Me.TextBox23.Text = "MEASURED"
        Me.TextBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox24
        '
        Me.TextBox24.Location = New System.Drawing.Point(160, 6)
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New System.Drawing.Size(146, 20)
        Me.TextBox24.TabIndex = 22
        Me.TextBox24.Text = "HIGH LIMIT"
        Me.TextBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox25
        '
        Me.TextBox25.Location = New System.Drawing.Point(7, 6)
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New System.Drawing.Size(147, 20)
        Me.TextBox25.TabIndex = 21
        Me.TextBox25.Text = "PARAMETER"
        Me.TextBox25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Button40)
        Me.TabPage3.Controls.Add(Me.TextBox152)
        Me.TabPage3.Controls.Add(Me.PictureBox3)
        Me.TabPage3.Controls.Add(Me.TabControl2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(801, 565)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "SMC"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Button40
        '
        Me.Button40.BackColor = System.Drawing.Color.Lime
        Me.Button40.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button40.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button40.Font = New System.Drawing.Font("Bookman Old Style", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button40.Location = New System.Drawing.Point(529, 504)
        Me.Button40.Name = "Button40"
        Me.Button40.Size = New System.Drawing.Size(260, 50)
        Me.Button40.TabIndex = 3
        Me.Button40.Text = "CONTINUE"
        Me.Button40.UseVisualStyleBackColor = False
        '
        'TextBox152
        '
        Me.TextBox152.Font = New System.Drawing.Font("Californian FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox152.Location = New System.Drawing.Point(530, 171)
        Me.TextBox152.Multiline = True
        Me.TextBox152.Name = "TextBox152"
        Me.TextBox152.Size = New System.Drawing.Size(258, 209)
        Me.TextBox152.TabIndex = 2
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(13, 165)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(506, 389)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage6)
        Me.TabControl2.Controls.Add(Me.TabPage7)
        Me.TabControl2.Controls.Add(Me.TabPage8)
        Me.TabControl2.Controls.Add(Me.TabPage10)
        Me.TabControl2.Controls.Add(Me.TabPage11)
        Me.TabControl2.Controls.Add(Me.TabPage12)
        Me.TabControl2.Location = New System.Drawing.Point(8, 9)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(787, 145)
        Me.TabControl2.TabIndex = 0
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.Button17)
        Me.TabPage6.Controls.Add(Me.TextBox38)
        Me.TabPage6.Controls.Add(Me.Button16)
        Me.TabPage6.Controls.Add(Me.TextBox37)
        Me.TabPage6.Controls.Add(Me.TextBox26)
        Me.TabPage6.Controls.Add(Me.TextBox36)
        Me.TabPage6.Controls.Add(Me.TextBox27)
        Me.TabPage6.Controls.Add(Me.TextBox35)
        Me.TabPage6.Controls.Add(Me.TextBox28)
        Me.TabPage6.Controls.Add(Me.TextBox29)
        Me.TabPage6.Controls.Add(Me.TextBox30)
        Me.TabPage6.Controls.Add(Me.TextBox31)
        Me.TabPage6.Controls.Add(Me.TextBox32)
        Me.TabPage6.Controls.Add(Me.TextBox33)
        Me.TabPage6.Controls.Add(Me.TextBox34)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(779, 119)
        Me.TabPage6.TabIndex = 0
        Me.TabPage6.Text = "PROGRAMMING "
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'Button17
        '
        Me.Button17.Location = New System.Drawing.Point(617, 70)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(140, 23)
        Me.Button17.TabIndex = 40
        Me.Button17.UseVisualStyleBackColor = True
        '
        'TextBox38
        '
        Me.TextBox38.Location = New System.Drawing.Point(465, 72)
        Me.TextBox38.Name = "TextBox38"
        Me.TextBox38.Size = New System.Drawing.Size(146, 20)
        Me.TextBox38.TabIndex = 39
        Me.TextBox38.Text = "TRUE"
        Me.TextBox38.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button16
        '
        Me.Button16.Location = New System.Drawing.Point(617, 41)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(140, 23)
        Me.Button16.TabIndex = 40
        Me.Button16.UseVisualStyleBackColor = True
        '
        'TextBox37
        '
        Me.TextBox37.Location = New System.Drawing.Point(311, 72)
        Me.TextBox37.Name = "TextBox37"
        Me.TextBox37.Size = New System.Drawing.Size(146, 20)
        Me.TextBox37.TabIndex = 38
        Me.TextBox37.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox26
        '
        Me.TextBox26.Location = New System.Drawing.Point(465, 43)
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New System.Drawing.Size(146, 20)
        Me.TextBox26.TabIndex = 39
        Me.TextBox26.Text = "TRUE"
        Me.TextBox26.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox36
        '
        Me.TextBox36.Location = New System.Drawing.Point(159, 72)
        Me.TextBox36.Name = "TextBox36"
        Me.TextBox36.Size = New System.Drawing.Size(146, 20)
        Me.TextBox36.TabIndex = 37
        Me.TextBox36.Text = "TRUE"
        Me.TextBox36.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox27
        '
        Me.TextBox27.Location = New System.Drawing.Point(311, 43)
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Size = New System.Drawing.Size(146, 20)
        Me.TextBox27.TabIndex = 38
        Me.TextBox27.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox35
        '
        Me.TextBox35.Location = New System.Drawing.Point(6, 72)
        Me.TextBox35.Name = "TextBox35"
        Me.TextBox35.Size = New System.Drawing.Size(147, 20)
        Me.TextBox35.TabIndex = 36
        Me.TextBox35.Text = "FTDI PROGRAMMING"
        Me.TextBox35.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox28
        '
        Me.TextBox28.Location = New System.Drawing.Point(159, 43)
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Size = New System.Drawing.Size(146, 20)
        Me.TextBox28.TabIndex = 37
        Me.TextBox28.Text = "TRUE"
        Me.TextBox28.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox29
        '
        Me.TextBox29.Location = New System.Drawing.Point(6, 43)
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Size = New System.Drawing.Size(147, 20)
        Me.TextBox29.TabIndex = 36
        Me.TextBox29.Text = "FIRMWARE FLASH"
        Me.TextBox29.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox30
        '
        Me.TextBox30.Location = New System.Drawing.Point(617, 4)
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Size = New System.Drawing.Size(140, 20)
        Me.TextBox30.TabIndex = 35
        Me.TextBox30.Text = "TEST STATUS"
        Me.TextBox30.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox31
        '
        Me.TextBox31.Location = New System.Drawing.Point(461, 4)
        Me.TextBox31.Name = "TextBox31"
        Me.TextBox31.Size = New System.Drawing.Size(150, 20)
        Me.TextBox31.TabIndex = 34
        Me.TextBox31.Text = "LOW LIMIT"
        Me.TextBox31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox32
        '
        Me.TextBox32.Location = New System.Drawing.Point(311, 5)
        Me.TextBox32.Name = "TextBox32"
        Me.TextBox32.Size = New System.Drawing.Size(146, 20)
        Me.TextBox32.TabIndex = 33
        Me.TextBox32.Text = "MEASURED"
        Me.TextBox32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox33
        '
        Me.TextBox33.Location = New System.Drawing.Point(159, 5)
        Me.TextBox33.Name = "TextBox33"
        Me.TextBox33.Size = New System.Drawing.Size(146, 20)
        Me.TextBox33.TabIndex = 32
        Me.TextBox33.Text = "HIGH LIMIT"
        Me.TextBox33.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox34
        '
        Me.TextBox34.Location = New System.Drawing.Point(6, 5)
        Me.TextBox34.Name = "TextBox34"
        Me.TextBox34.Size = New System.Drawing.Size(147, 20)
        Me.TextBox34.TabIndex = 31
        Me.TextBox34.Text = "PARAMETER"
        Me.TextBox34.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TabPage7
        '
        Me.TabPage7.AutoScroll = True
        Me.TabPage7.Controls.Add(Me.Button25)
        Me.TabPage7.Controls.Add(Me.TextBox75)
        Me.TabPage7.Controls.Add(Me.Button24)
        Me.TabPage7.Controls.Add(Me.TextBox74)
        Me.TabPage7.Controls.Add(Me.TextBox68)
        Me.TabPage7.Controls.Add(Me.TextBox73)
        Me.TabPage7.Controls.Add(Me.TextBox69)
        Me.TabPage7.Controls.Add(Me.TextBox72)
        Me.TabPage7.Controls.Add(Me.TextBox70)
        Me.TabPage7.Controls.Add(Me.TextBox71)
        Me.TabPage7.Controls.Add(Me.Button23)
        Me.TabPage7.Controls.Add(Me.TextBox67)
        Me.TabPage7.Controls.Add(Me.Button22)
        Me.TabPage7.Controls.Add(Me.TextBox63)
        Me.TabPage7.Controls.Add(Me.Button21)
        Me.TabPage7.Controls.Add(Me.TextBox59)
        Me.TabPage7.Controls.Add(Me.Button20)
        Me.TabPage7.Controls.Add(Me.TextBox66)
        Me.TabPage7.Controls.Add(Me.TextBox55)
        Me.TabPage7.Controls.Add(Me.TextBox62)
        Me.TabPage7.Controls.Add(Me.Button18)
        Me.TabPage7.Controls.Add(Me.TextBox58)
        Me.TabPage7.Controls.Add(Me.TextBox39)
        Me.TabPage7.Controls.Add(Me.TextBox65)
        Me.TabPage7.Controls.Add(Me.TextBox54)
        Me.TabPage7.Controls.Add(Me.TextBox61)
        Me.TabPage7.Controls.Add(Me.Button19)
        Me.TabPage7.Controls.Add(Me.TextBox57)
        Me.TabPage7.Controls.Add(Me.TextBox40)
        Me.TabPage7.Controls.Add(Me.TextBox64)
        Me.TabPage7.Controls.Add(Me.TextBox53)
        Me.TabPage7.Controls.Add(Me.TextBox60)
        Me.TabPage7.Controls.Add(Me.TextBox41)
        Me.TabPage7.Controls.Add(Me.TextBox56)
        Me.TabPage7.Controls.Add(Me.TextBox42)
        Me.TabPage7.Controls.Add(Me.TextBox52)
        Me.TabPage7.Controls.Add(Me.TextBox43)
        Me.TabPage7.Controls.Add(Me.TextBox44)
        Me.TabPage7.Controls.Add(Me.TextBox45)
        Me.TabPage7.Controls.Add(Me.TextBox46)
        Me.TabPage7.Controls.Add(Me.TextBox47)
        Me.TabPage7.Controls.Add(Me.TextBox48)
        Me.TabPage7.Controls.Add(Me.TextBox49)
        Me.TabPage7.Controls.Add(Me.TextBox50)
        Me.TabPage7.Controls.Add(Me.TextBox51)
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(779, 119)
        Me.TabPage7.TabIndex = 1
        Me.TabPage7.Text = "POWER"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'Button25
        '
        Me.Button25.Location = New System.Drawing.Point(617, 242)
        Me.Button25.Name = "Button25"
        Me.Button25.Size = New System.Drawing.Size(140, 23)
        Me.Button25.TabIndex = 60
        Me.Button25.UseVisualStyleBackColor = True
        '
        'TextBox75
        '
        Me.TextBox75.Location = New System.Drawing.Point(465, 244)
        Me.TextBox75.Name = "TextBox75"
        Me.TextBox75.Size = New System.Drawing.Size(146, 20)
        Me.TextBox75.TabIndex = 59
        Me.TextBox75.Text = "0.4"
        Me.TextBox75.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button24
        '
        Me.Button24.Location = New System.Drawing.Point(617, 213)
        Me.Button24.Name = "Button24"
        Me.Button24.Size = New System.Drawing.Size(140, 23)
        Me.Button24.TabIndex = 60
        Me.Button24.UseVisualStyleBackColor = True
        '
        'TextBox74
        '
        Me.TextBox74.Location = New System.Drawing.Point(311, 244)
        Me.TextBox74.Name = "TextBox74"
        Me.TextBox74.Size = New System.Drawing.Size(146, 20)
        Me.TextBox74.TabIndex = 58
        Me.TextBox74.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox68
        '
        Me.TextBox68.Location = New System.Drawing.Point(465, 215)
        Me.TextBox68.Name = "TextBox68"
        Me.TextBox68.Size = New System.Drawing.Size(146, 20)
        Me.TextBox68.TabIndex = 59
        Me.TextBox68.Text = "0.4"
        Me.TextBox68.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox73
        '
        Me.TextBox73.Location = New System.Drawing.Point(159, 244)
        Me.TextBox73.Name = "TextBox73"
        Me.TextBox73.Size = New System.Drawing.Size(146, 20)
        Me.TextBox73.TabIndex = 57
        Me.TextBox73.Text = "0.0"
        Me.TextBox73.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox69
        '
        Me.TextBox69.Location = New System.Drawing.Point(311, 215)
        Me.TextBox69.Name = "TextBox69"
        Me.TextBox69.Size = New System.Drawing.Size(146, 20)
        Me.TextBox69.TabIndex = 58
        Me.TextBox69.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox72
        '
        Me.TextBox72.Location = New System.Drawing.Point(6, 244)
        Me.TextBox72.Name = "TextBox72"
        Me.TextBox72.Size = New System.Drawing.Size(147, 20)
        Me.TextBox72.TabIndex = 56
        Me.TextBox72.Text = "D0691_CMD_ON"
        Me.TextBox72.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox70
        '
        Me.TextBox70.Location = New System.Drawing.Point(159, 215)
        Me.TextBox70.Name = "TextBox70"
        Me.TextBox70.Size = New System.Drawing.Size(146, 20)
        Me.TextBox70.TabIndex = 57
        Me.TextBox70.Text = "0.0"
        Me.TextBox70.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox71
        '
        Me.TextBox71.Location = New System.Drawing.Point(6, 215)
        Me.TextBox71.Name = "TextBox71"
        Me.TextBox71.Size = New System.Drawing.Size(147, 20)
        Me.TextBox71.TabIndex = 56
        Me.TextBox71.Text = "A0691"
        Me.TextBox71.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button23
        '
        Me.Button23.Location = New System.Drawing.Point(617, 187)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(140, 23)
        Me.Button23.TabIndex = 54
        Me.Button23.UseVisualStyleBackColor = True
        '
        'TextBox67
        '
        Me.TextBox67.Location = New System.Drawing.Point(465, 189)
        Me.TextBox67.Name = "TextBox67"
        Me.TextBox67.Size = New System.Drawing.Size(146, 20)
        Me.TextBox67.TabIndex = 52
        Me.TextBox67.Text = "5.5"
        Me.TextBox67.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button22
        '
        Me.Button22.Location = New System.Drawing.Point(617, 158)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(140, 23)
        Me.Button22.TabIndex = 54
        Me.Button22.UseVisualStyleBackColor = True
        '
        'TextBox63
        '
        Me.TextBox63.Location = New System.Drawing.Point(465, 160)
        Me.TextBox63.Name = "TextBox63"
        Me.TextBox63.Size = New System.Drawing.Size(146, 20)
        Me.TextBox63.TabIndex = 52
        Me.TextBox63.Text = "5.5"
        Me.TextBox63.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button21
        '
        Me.Button21.Location = New System.Drawing.Point(617, 129)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(140, 23)
        Me.Button21.TabIndex = 54
        Me.Button21.UseVisualStyleBackColor = True
        '
        'TextBox59
        '
        Me.TextBox59.Location = New System.Drawing.Point(465, 131)
        Me.TextBox59.Name = "TextBox59"
        Me.TextBox59.Size = New System.Drawing.Size(146, 20)
        Me.TextBox59.TabIndex = 52
        Me.TextBox59.Text = "12.5"
        Me.TextBox59.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button20
        '
        Me.Button20.Location = New System.Drawing.Point(617, 102)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(140, 23)
        Me.Button20.TabIndex = 54
        Me.Button20.UseVisualStyleBackColor = True
        '
        'TextBox66
        '
        Me.TextBox66.Location = New System.Drawing.Point(311, 189)
        Me.TextBox66.Name = "TextBox66"
        Me.TextBox66.Size = New System.Drawing.Size(146, 20)
        Me.TextBox66.TabIndex = 50
        Me.TextBox66.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox55
        '
        Me.TextBox55.Location = New System.Drawing.Point(465, 104)
        Me.TextBox55.Name = "TextBox55"
        Me.TextBox55.Size = New System.Drawing.Size(146, 20)
        Me.TextBox55.TabIndex = 52
        Me.TextBox55.Text = "12.5"
        Me.TextBox55.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox62
        '
        Me.TextBox62.Location = New System.Drawing.Point(311, 160)
        Me.TextBox62.Name = "TextBox62"
        Me.TextBox62.Size = New System.Drawing.Size(146, 20)
        Me.TextBox62.TabIndex = 50
        Me.TextBox62.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button18
        '
        Me.Button18.Location = New System.Drawing.Point(617, 73)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(140, 23)
        Me.Button18.TabIndex = 54
        Me.Button18.UseVisualStyleBackColor = True
        '
        'TextBox58
        '
        Me.TextBox58.Location = New System.Drawing.Point(311, 131)
        Me.TextBox58.Name = "TextBox58"
        Me.TextBox58.Size = New System.Drawing.Size(146, 20)
        Me.TextBox58.TabIndex = 50
        Me.TextBox58.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox39
        '
        Me.TextBox39.Location = New System.Drawing.Point(465, 75)
        Me.TextBox39.Name = "TextBox39"
        Me.TextBox39.Size = New System.Drawing.Size(146, 20)
        Me.TextBox39.TabIndex = 52
        Me.TextBox39.Text = "5.5"
        Me.TextBox39.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox65
        '
        Me.TextBox65.Location = New System.Drawing.Point(159, 189)
        Me.TextBox65.Name = "TextBox65"
        Me.TextBox65.Size = New System.Drawing.Size(146, 20)
        Me.TextBox65.TabIndex = 48
        Me.TextBox65.Text = "4.5"
        Me.TextBox65.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox54
        '
        Me.TextBox54.Location = New System.Drawing.Point(311, 104)
        Me.TextBox54.Name = "TextBox54"
        Me.TextBox54.Size = New System.Drawing.Size(146, 20)
        Me.TextBox54.TabIndex = 50
        Me.TextBox54.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox61
        '
        Me.TextBox61.Location = New System.Drawing.Point(159, 160)
        Me.TextBox61.Name = "TextBox61"
        Me.TextBox61.Size = New System.Drawing.Size(146, 20)
        Me.TextBox61.TabIndex = 48
        Me.TextBox61.Text = "4.5"
        Me.TextBox61.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button19
        '
        Me.Button19.Location = New System.Drawing.Point(617, 44)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(140, 23)
        Me.Button19.TabIndex = 55
        Me.Button19.UseVisualStyleBackColor = True
        '
        'TextBox57
        '
        Me.TextBox57.Location = New System.Drawing.Point(159, 131)
        Me.TextBox57.Name = "TextBox57"
        Me.TextBox57.Size = New System.Drawing.Size(146, 20)
        Me.TextBox57.TabIndex = 48
        Me.TextBox57.Text = "11.5"
        Me.TextBox57.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox40
        '
        Me.TextBox40.Location = New System.Drawing.Point(311, 75)
        Me.TextBox40.Name = "TextBox40"
        Me.TextBox40.Size = New System.Drawing.Size(146, 20)
        Me.TextBox40.TabIndex = 50
        Me.TextBox40.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox64
        '
        Me.TextBox64.Location = New System.Drawing.Point(6, 189)
        Me.TextBox64.Name = "TextBox64"
        Me.TextBox64.Size = New System.Drawing.Size(147, 20)
        Me.TextBox64.TabIndex = 46
        Me.TextBox64.Text = "IT661_5V"
        Me.TextBox64.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox53
        '
        Me.TextBox53.Location = New System.Drawing.Point(159, 104)
        Me.TextBox53.Name = "TextBox53"
        Me.TextBox53.Size = New System.Drawing.Size(146, 20)
        Me.TextBox53.TabIndex = 48
        Me.TextBox53.Text = "11.5"
        Me.TextBox53.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox60
        '
        Me.TextBox60.Location = New System.Drawing.Point(6, 160)
        Me.TextBox60.Name = "TextBox60"
        Me.TextBox60.Size = New System.Drawing.Size(147, 20)
        Me.TextBox60.TabIndex = 46
        Me.TextBox60.Text = "TT620 5V"
        Me.TextBox60.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox41
        '
        Me.TextBox41.Location = New System.Drawing.Point(465, 46)
        Me.TextBox41.Name = "TextBox41"
        Me.TextBox41.Size = New System.Drawing.Size(146, 20)
        Me.TextBox41.TabIndex = 53
        Me.TextBox41.Text = "TRUE"
        Me.TextBox41.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox56
        '
        Me.TextBox56.Location = New System.Drawing.Point(6, 131)
        Me.TextBox56.Name = "TextBox56"
        Me.TextBox56.Size = New System.Drawing.Size(147, 20)
        Me.TextBox56.TabIndex = 46
        Me.TextBox56.Text = "SENSOR V+12"
        Me.TextBox56.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox42
        '
        Me.TextBox42.Location = New System.Drawing.Point(159, 75)
        Me.TextBox42.Name = "TextBox42"
        Me.TextBox42.Size = New System.Drawing.Size(146, 20)
        Me.TextBox42.TabIndex = 48
        Me.TextBox42.Text = "4.5"
        Me.TextBox42.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox52
        '
        Me.TextBox52.Location = New System.Drawing.Point(6, 104)
        Me.TextBox52.Name = "TextBox52"
        Me.TextBox52.Size = New System.Drawing.Size(147, 20)
        Me.TextBox52.TabIndex = 46
        Me.TextBox52.Text = "ISOLATED V+12"
        Me.TextBox52.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox43
        '
        Me.TextBox43.Location = New System.Drawing.Point(311, 46)
        Me.TextBox43.Name = "TextBox43"
        Me.TextBox43.Size = New System.Drawing.Size(146, 20)
        Me.TextBox43.TabIndex = 51
        Me.TextBox43.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox44
        '
        Me.TextBox44.Location = New System.Drawing.Point(6, 75)
        Me.TextBox44.Name = "TextBox44"
        Me.TextBox44.Size = New System.Drawing.Size(147, 20)
        Me.TextBox44.TabIndex = 46
        Me.TextBox44.Text = "CAN670_5V"
        Me.TextBox44.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox45
        '
        Me.TextBox45.Location = New System.Drawing.Point(159, 46)
        Me.TextBox45.Name = "TextBox45"
        Me.TextBox45.Size = New System.Drawing.Size(146, 20)
        Me.TextBox45.TabIndex = 49
        Me.TextBox45.Text = "TRUE"
        Me.TextBox45.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox46
        '
        Me.TextBox46.Location = New System.Drawing.Point(6, 46)
        Me.TextBox46.Name = "TextBox46"
        Me.TextBox46.Size = New System.Drawing.Size(147, 20)
        Me.TextBox46.TabIndex = 47
        Me.TextBox46.Text = "INITIAL POWER"
        Me.TextBox46.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox47
        '
        Me.TextBox47.Location = New System.Drawing.Point(617, 6)
        Me.TextBox47.Name = "TextBox47"
        Me.TextBox47.Size = New System.Drawing.Size(140, 20)
        Me.TextBox47.TabIndex = 45
        Me.TextBox47.Text = "TEST STATUS"
        Me.TextBox47.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox48
        '
        Me.TextBox48.Location = New System.Drawing.Point(461, 7)
        Me.TextBox48.Name = "TextBox48"
        Me.TextBox48.Size = New System.Drawing.Size(150, 20)
        Me.TextBox48.TabIndex = 44
        Me.TextBox48.Text = "LOW LIMIT"
        Me.TextBox48.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox49
        '
        Me.TextBox49.Location = New System.Drawing.Point(311, 8)
        Me.TextBox49.Name = "TextBox49"
        Me.TextBox49.Size = New System.Drawing.Size(146, 20)
        Me.TextBox49.TabIndex = 43
        Me.TextBox49.Text = "MEASURED"
        Me.TextBox49.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox50
        '
        Me.TextBox50.Location = New System.Drawing.Point(159, 8)
        Me.TextBox50.Name = "TextBox50"
        Me.TextBox50.Size = New System.Drawing.Size(146, 20)
        Me.TextBox50.TabIndex = 42
        Me.TextBox50.Text = "HIGH LIMIT"
        Me.TextBox50.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox51
        '
        Me.TextBox51.Location = New System.Drawing.Point(6, 8)
        Me.TextBox51.Name = "TextBox51"
        Me.TextBox51.Size = New System.Drawing.Size(147, 20)
        Me.TextBox51.TabIndex = 41
        Me.TextBox51.Text = "PARAMETER"
        Me.TextBox51.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TabPage8
        '
        Me.TabPage8.AutoScroll = True
        Me.TabPage8.Controls.Add(Me.Button36)
        Me.TabPage8.Controls.Add(Me.TextBox124)
        Me.TabPage8.Controls.Add(Me.Button35)
        Me.TabPage8.Controls.Add(Me.TextBox120)
        Me.TabPage8.Controls.Add(Me.Button34)
        Me.TabPage8.Controls.Add(Me.TextBox116)
        Me.TabPage8.Controls.Add(Me.Button33)
        Me.TabPage8.Controls.Add(Me.TextBox112)
        Me.TabPage8.Controls.Add(Me.Button32)
        Me.TabPage8.Controls.Add(Me.TextBox108)
        Me.TabPage8.Controls.Add(Me.TextBox123)
        Me.TabPage8.Controls.Add(Me.Button31)
        Me.TabPage8.Controls.Add(Me.TextBox119)
        Me.TabPage8.Controls.Add(Me.TextBox104)
        Me.TabPage8.Controls.Add(Me.TextBox115)
        Me.TabPage8.Controls.Add(Me.Button30)
        Me.TabPage8.Controls.Add(Me.TextBox111)
        Me.TabPage8.Controls.Add(Me.TextBox100)
        Me.TabPage8.Controls.Add(Me.TextBox107)
        Me.TabPage8.Controls.Add(Me.TextBox122)
        Me.TabPage8.Controls.Add(Me.Button29)
        Me.TabPage8.Controls.Add(Me.TextBox118)
        Me.TabPage8.Controls.Add(Me.TextBox103)
        Me.TabPage8.Controls.Add(Me.TextBox114)
        Me.TabPage8.Controls.Add(Me.TextBox96)
        Me.TabPage8.Controls.Add(Me.TextBox110)
        Me.TabPage8.Controls.Add(Me.TextBox99)
        Me.TabPage8.Controls.Add(Me.TextBox106)
        Me.TabPage8.Controls.Add(Me.TextBox121)
        Me.TabPage8.Controls.Add(Me.Button28)
        Me.TabPage8.Controls.Add(Me.TextBox117)
        Me.TabPage8.Controls.Add(Me.TextBox102)
        Me.TabPage8.Controls.Add(Me.TextBox113)
        Me.TabPage8.Controls.Add(Me.TextBox95)
        Me.TabPage8.Controls.Add(Me.TextBox109)
        Me.TabPage8.Controls.Add(Me.TextBox98)
        Me.TabPage8.Controls.Add(Me.TextBox105)
        Me.TabPage8.Controls.Add(Me.TextBox89)
        Me.TabPage8.Controls.Add(Me.TextBox101)
        Me.TabPage8.Controls.Add(Me.TextBox94)
        Me.TabPage8.Controls.Add(Me.TextBox97)
        Me.TabPage8.Controls.Add(Me.TextBox90)
        Me.TabPage8.Controls.Add(Me.TextBox93)
        Me.TabPage8.Controls.Add(Me.TextBox91)
        Me.TabPage8.Controls.Add(Me.TextBox92)
        Me.TabPage8.Controls.Add(Me.Button27)
        Me.TabPage8.Controls.Add(Me.TextBox85)
        Me.TabPage8.Controls.Add(Me.TextBox86)
        Me.TabPage8.Controls.Add(Me.TextBox87)
        Me.TabPage8.Controls.Add(Me.TextBox88)
        Me.TabPage8.Controls.Add(Me.Button26)
        Me.TabPage8.Controls.Add(Me.TextBox81)
        Me.TabPage8.Controls.Add(Me.TextBox82)
        Me.TabPage8.Controls.Add(Me.TextBox83)
        Me.TabPage8.Controls.Add(Me.TextBox84)
        Me.TabPage8.Controls.Add(Me.TextBox76)
        Me.TabPage8.Controls.Add(Me.TextBox77)
        Me.TabPage8.Controls.Add(Me.TextBox78)
        Me.TabPage8.Controls.Add(Me.TextBox79)
        Me.TabPage8.Controls.Add(Me.TextBox80)
        Me.TabPage8.Location = New System.Drawing.Point(4, 22)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage8.Size = New System.Drawing.Size(779, 119)
        Me.TabPage8.TabIndex = 2
        Me.TabPage8.Text = "SWITCH"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'Button36
        '
        Me.Button36.Location = New System.Drawing.Point(617, 313)
        Me.Button36.Name = "Button36"
        Me.Button36.Size = New System.Drawing.Size(140, 23)
        Me.Button36.TabIndex = 75
        Me.Button36.UseVisualStyleBackColor = True
        '
        'TextBox124
        '
        Me.TextBox124.Location = New System.Drawing.Point(465, 315)
        Me.TextBox124.Name = "TextBox124"
        Me.TextBox124.Size = New System.Drawing.Size(146, 20)
        Me.TextBox124.TabIndex = 74
        Me.TextBox124.Text = "TRUE"
        Me.TextBox124.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button35
        '
        Me.Button35.Location = New System.Drawing.Point(617, 284)
        Me.Button35.Name = "Button35"
        Me.Button35.Size = New System.Drawing.Size(140, 23)
        Me.Button35.TabIndex = 75
        Me.Button35.UseVisualStyleBackColor = True
        '
        'TextBox120
        '
        Me.TextBox120.Location = New System.Drawing.Point(465, 286)
        Me.TextBox120.Name = "TextBox120"
        Me.TextBox120.Size = New System.Drawing.Size(146, 20)
        Me.TextBox120.TabIndex = 74
        Me.TextBox120.Text = "TRUE"
        Me.TextBox120.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button34
        '
        Me.Button34.Location = New System.Drawing.Point(617, 255)
        Me.Button34.Name = "Button34"
        Me.Button34.Size = New System.Drawing.Size(140, 23)
        Me.Button34.TabIndex = 75
        Me.Button34.UseVisualStyleBackColor = True
        '
        'TextBox116
        '
        Me.TextBox116.Location = New System.Drawing.Point(465, 257)
        Me.TextBox116.Name = "TextBox116"
        Me.TextBox116.Size = New System.Drawing.Size(146, 20)
        Me.TextBox116.TabIndex = 74
        Me.TextBox116.Text = "TRUE"
        Me.TextBox116.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button33
        '
        Me.Button33.Location = New System.Drawing.Point(617, 226)
        Me.Button33.Name = "Button33"
        Me.Button33.Size = New System.Drawing.Size(140, 23)
        Me.Button33.TabIndex = 75
        Me.Button33.UseVisualStyleBackColor = True
        '
        'TextBox112
        '
        Me.TextBox112.Location = New System.Drawing.Point(465, 228)
        Me.TextBox112.Name = "TextBox112"
        Me.TextBox112.Size = New System.Drawing.Size(146, 20)
        Me.TextBox112.TabIndex = 74
        Me.TextBox112.Text = "TRUE"
        Me.TextBox112.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button32
        '
        Me.Button32.Location = New System.Drawing.Point(617, 197)
        Me.Button32.Name = "Button32"
        Me.Button32.Size = New System.Drawing.Size(140, 23)
        Me.Button32.TabIndex = 75
        Me.Button32.UseVisualStyleBackColor = True
        '
        'TextBox108
        '
        Me.TextBox108.Location = New System.Drawing.Point(465, 199)
        Me.TextBox108.Name = "TextBox108"
        Me.TextBox108.Size = New System.Drawing.Size(146, 20)
        Me.TextBox108.TabIndex = 74
        Me.TextBox108.Text = "TRUE"
        Me.TextBox108.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox123
        '
        Me.TextBox123.Location = New System.Drawing.Point(311, 315)
        Me.TextBox123.Name = "TextBox123"
        Me.TextBox123.Size = New System.Drawing.Size(146, 20)
        Me.TextBox123.TabIndex = 73
        Me.TextBox123.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button31
        '
        Me.Button31.Location = New System.Drawing.Point(617, 168)
        Me.Button31.Name = "Button31"
        Me.Button31.Size = New System.Drawing.Size(140, 23)
        Me.Button31.TabIndex = 75
        Me.Button31.UseVisualStyleBackColor = True
        '
        'TextBox119
        '
        Me.TextBox119.Location = New System.Drawing.Point(311, 286)
        Me.TextBox119.Name = "TextBox119"
        Me.TextBox119.Size = New System.Drawing.Size(146, 20)
        Me.TextBox119.TabIndex = 73
        Me.TextBox119.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox104
        '
        Me.TextBox104.Location = New System.Drawing.Point(465, 170)
        Me.TextBox104.Name = "TextBox104"
        Me.TextBox104.Size = New System.Drawing.Size(146, 20)
        Me.TextBox104.TabIndex = 74
        Me.TextBox104.Text = "TRUE"
        Me.TextBox104.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox115
        '
        Me.TextBox115.Location = New System.Drawing.Point(311, 257)
        Me.TextBox115.Name = "TextBox115"
        Me.TextBox115.Size = New System.Drawing.Size(146, 20)
        Me.TextBox115.TabIndex = 73
        Me.TextBox115.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button30
        '
        Me.Button30.Location = New System.Drawing.Point(617, 139)
        Me.Button30.Name = "Button30"
        Me.Button30.Size = New System.Drawing.Size(140, 23)
        Me.Button30.TabIndex = 75
        Me.Button30.UseVisualStyleBackColor = True
        '
        'TextBox111
        '
        Me.TextBox111.Location = New System.Drawing.Point(311, 228)
        Me.TextBox111.Name = "TextBox111"
        Me.TextBox111.Size = New System.Drawing.Size(146, 20)
        Me.TextBox111.TabIndex = 73
        Me.TextBox111.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox100
        '
        Me.TextBox100.Location = New System.Drawing.Point(465, 141)
        Me.TextBox100.Name = "TextBox100"
        Me.TextBox100.Size = New System.Drawing.Size(146, 20)
        Me.TextBox100.TabIndex = 74
        Me.TextBox100.Text = "TRUE"
        Me.TextBox100.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox107
        '
        Me.TextBox107.Location = New System.Drawing.Point(311, 199)
        Me.TextBox107.Name = "TextBox107"
        Me.TextBox107.Size = New System.Drawing.Size(146, 20)
        Me.TextBox107.TabIndex = 73
        Me.TextBox107.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox122
        '
        Me.TextBox122.Location = New System.Drawing.Point(159, 315)
        Me.TextBox122.Name = "TextBox122"
        Me.TextBox122.Size = New System.Drawing.Size(146, 20)
        Me.TextBox122.TabIndex = 72
        Me.TextBox122.Text = "TRUE"
        Me.TextBox122.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button29
        '
        Me.Button29.Location = New System.Drawing.Point(617, 110)
        Me.Button29.Name = "Button29"
        Me.Button29.Size = New System.Drawing.Size(140, 23)
        Me.Button29.TabIndex = 75
        Me.Button29.UseVisualStyleBackColor = True
        '
        'TextBox118
        '
        Me.TextBox118.Location = New System.Drawing.Point(159, 286)
        Me.TextBox118.Name = "TextBox118"
        Me.TextBox118.Size = New System.Drawing.Size(146, 20)
        Me.TextBox118.TabIndex = 72
        Me.TextBox118.Text = "TRUE"
        Me.TextBox118.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox103
        '
        Me.TextBox103.Location = New System.Drawing.Point(311, 170)
        Me.TextBox103.Name = "TextBox103"
        Me.TextBox103.Size = New System.Drawing.Size(146, 20)
        Me.TextBox103.TabIndex = 73
        Me.TextBox103.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox114
        '
        Me.TextBox114.Location = New System.Drawing.Point(159, 257)
        Me.TextBox114.Name = "TextBox114"
        Me.TextBox114.Size = New System.Drawing.Size(146, 20)
        Me.TextBox114.TabIndex = 72
        Me.TextBox114.Text = "TRUE"
        Me.TextBox114.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox96
        '
        Me.TextBox96.Location = New System.Drawing.Point(465, 112)
        Me.TextBox96.Name = "TextBox96"
        Me.TextBox96.Size = New System.Drawing.Size(146, 20)
        Me.TextBox96.TabIndex = 74
        Me.TextBox96.Text = "TRUE"
        Me.TextBox96.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox110
        '
        Me.TextBox110.Location = New System.Drawing.Point(159, 228)
        Me.TextBox110.Name = "TextBox110"
        Me.TextBox110.Size = New System.Drawing.Size(146, 20)
        Me.TextBox110.TabIndex = 72
        Me.TextBox110.Text = "TRUE"
        Me.TextBox110.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox99
        '
        Me.TextBox99.Location = New System.Drawing.Point(311, 141)
        Me.TextBox99.Name = "TextBox99"
        Me.TextBox99.Size = New System.Drawing.Size(146, 20)
        Me.TextBox99.TabIndex = 73
        Me.TextBox99.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox106
        '
        Me.TextBox106.Location = New System.Drawing.Point(159, 199)
        Me.TextBox106.Name = "TextBox106"
        Me.TextBox106.Size = New System.Drawing.Size(146, 20)
        Me.TextBox106.TabIndex = 72
        Me.TextBox106.Text = "TRUE"
        Me.TextBox106.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox121
        '
        Me.TextBox121.Location = New System.Drawing.Point(6, 315)
        Me.TextBox121.Name = "TextBox121"
        Me.TextBox121.Size = New System.Drawing.Size(147, 20)
        Me.TextBox121.TabIndex = 71
        Me.TextBox121.Text = "CAN2_SILENCE ON"
        Me.TextBox121.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button28
        '
        Me.Button28.Location = New System.Drawing.Point(617, 82)
        Me.Button28.Name = "Button28"
        Me.Button28.Size = New System.Drawing.Size(140, 23)
        Me.Button28.TabIndex = 75
        Me.Button28.UseVisualStyleBackColor = True
        '
        'TextBox117
        '
        Me.TextBox117.Location = New System.Drawing.Point(6, 286)
        Me.TextBox117.Name = "TextBox117"
        Me.TextBox117.Size = New System.Drawing.Size(147, 20)
        Me.TextBox117.TabIndex = 71
        Me.TextBox117.Text = "CAN1_SILENCE ON"
        Me.TextBox117.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox102
        '
        Me.TextBox102.Location = New System.Drawing.Point(159, 170)
        Me.TextBox102.Name = "TextBox102"
        Me.TextBox102.Size = New System.Drawing.Size(146, 20)
        Me.TextBox102.TabIndex = 72
        Me.TextBox102.Text = "TRUE"
        Me.TextBox102.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox113
        '
        Me.TextBox113.Location = New System.Drawing.Point(6, 257)
        Me.TextBox113.Name = "TextBox113"
        Me.TextBox113.Size = New System.Drawing.Size(147, 20)
        Me.TextBox113.TabIndex = 71
        Me.TextBox113.Text = "TOOGLE_CMD_ON"
        Me.TextBox113.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox95
        '
        Me.TextBox95.Location = New System.Drawing.Point(311, 112)
        Me.TextBox95.Name = "TextBox95"
        Me.TextBox95.Size = New System.Drawing.Size(146, 20)
        Me.TextBox95.TabIndex = 73
        Me.TextBox95.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox109
        '
        Me.TextBox109.Location = New System.Drawing.Point(6, 228)
        Me.TextBox109.Name = "TextBox109"
        Me.TextBox109.Size = New System.Drawing.Size(147, 20)
        Me.TextBox109.TabIndex = 71
        Me.TextBox109.Text = "CMD_SWITCH OFF"
        Me.TextBox109.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox98
        '
        Me.TextBox98.Location = New System.Drawing.Point(159, 141)
        Me.TextBox98.Name = "TextBox98"
        Me.TextBox98.Size = New System.Drawing.Size(146, 20)
        Me.TextBox98.TabIndex = 72
        Me.TextBox98.Text = "TRUE"
        Me.TextBox98.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox105
        '
        Me.TextBox105.Location = New System.Drawing.Point(6, 199)
        Me.TextBox105.Name = "TextBox105"
        Me.TextBox105.Size = New System.Drawing.Size(147, 20)
        Me.TextBox105.TabIndex = 71
        Me.TextBox105.Text = "D0101_CMD_OFF"
        Me.TextBox105.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox89
        '
        Me.TextBox89.Location = New System.Drawing.Point(465, 84)
        Me.TextBox89.Name = "TextBox89"
        Me.TextBox89.Size = New System.Drawing.Size(146, 20)
        Me.TextBox89.TabIndex = 74
        Me.TextBox89.Text = "TRUE"
        Me.TextBox89.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox101
        '
        Me.TextBox101.Location = New System.Drawing.Point(6, 170)
        Me.TextBox101.Name = "TextBox101"
        Me.TextBox101.Size = New System.Drawing.Size(147, 20)
        Me.TextBox101.TabIndex = 71
        Me.TextBox101.Text = "D0101_CMD_ON"
        Me.TextBox101.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox94
        '
        Me.TextBox94.Location = New System.Drawing.Point(159, 112)
        Me.TextBox94.Name = "TextBox94"
        Me.TextBox94.Size = New System.Drawing.Size(146, 20)
        Me.TextBox94.TabIndex = 72
        Me.TextBox94.Text = "TRUE"
        Me.TextBox94.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox97
        '
        Me.TextBox97.Location = New System.Drawing.Point(6, 141)
        Me.TextBox97.Name = "TextBox97"
        Me.TextBox97.Size = New System.Drawing.Size(147, 20)
        Me.TextBox97.TabIndex = 71
        Me.TextBox97.Text = "D0100_CMD_OFF"
        Me.TextBox97.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox90
        '
        Me.TextBox90.Location = New System.Drawing.Point(311, 84)
        Me.TextBox90.Name = "TextBox90"
        Me.TextBox90.Size = New System.Drawing.Size(146, 20)
        Me.TextBox90.TabIndex = 73
        Me.TextBox90.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox93
        '
        Me.TextBox93.Location = New System.Drawing.Point(6, 112)
        Me.TextBox93.Name = "TextBox93"
        Me.TextBox93.Size = New System.Drawing.Size(147, 20)
        Me.TextBox93.TabIndex = 71
        Me.TextBox93.Text = "D0100_CMD_ON"
        Me.TextBox93.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox91
        '
        Me.TextBox91.Location = New System.Drawing.Point(159, 84)
        Me.TextBox91.Name = "TextBox91"
        Me.TextBox91.Size = New System.Drawing.Size(146, 20)
        Me.TextBox91.TabIndex = 72
        Me.TextBox91.Text = "TRUE"
        Me.TextBox91.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox92
        '
        Me.TextBox92.Location = New System.Drawing.Point(6, 84)
        Me.TextBox92.Name = "TextBox92"
        Me.TextBox92.Size = New System.Drawing.Size(147, 20)
        Me.TextBox92.TabIndex = 71
        Me.TextBox92.Text = "AUX_EN CMD ON"
        Me.TextBox92.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button27
        '
        Me.Button27.Location = New System.Drawing.Point(617, 56)
        Me.Button27.Name = "Button27"
        Me.Button27.Size = New System.Drawing.Size(140, 23)
        Me.Button27.TabIndex = 70
        Me.Button27.UseVisualStyleBackColor = True
        '
        'TextBox85
        '
        Me.TextBox85.Location = New System.Drawing.Point(465, 58)
        Me.TextBox85.Name = "TextBox85"
        Me.TextBox85.Size = New System.Drawing.Size(146, 20)
        Me.TextBox85.TabIndex = 69
        Me.TextBox85.Text = "TRUE"
        Me.TextBox85.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox86
        '
        Me.TextBox86.Location = New System.Drawing.Point(311, 58)
        Me.TextBox86.Name = "TextBox86"
        Me.TextBox86.Size = New System.Drawing.Size(146, 20)
        Me.TextBox86.TabIndex = 68
        Me.TextBox86.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox87
        '
        Me.TextBox87.Location = New System.Drawing.Point(159, 58)
        Me.TextBox87.Name = "TextBox87"
        Me.TextBox87.Size = New System.Drawing.Size(146, 20)
        Me.TextBox87.TabIndex = 67
        Me.TextBox87.Text = "TRUE"
        Me.TextBox87.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox88
        '
        Me.TextBox88.Location = New System.Drawing.Point(6, 58)
        Me.TextBox88.Name = "TextBox88"
        Me.TextBox88.Size = New System.Drawing.Size(147, 20)
        Me.TextBox88.TabIndex = 66
        Me.TextBox88.Text = "D0661_CMD_OFF"
        Me.TextBox88.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button26
        '
        Me.Button26.Location = New System.Drawing.Point(617, 30)
        Me.Button26.Name = "Button26"
        Me.Button26.Size = New System.Drawing.Size(140, 23)
        Me.Button26.TabIndex = 65
        Me.Button26.UseVisualStyleBackColor = True
        '
        'TextBox81
        '
        Me.TextBox81.Location = New System.Drawing.Point(465, 32)
        Me.TextBox81.Name = "TextBox81"
        Me.TextBox81.Size = New System.Drawing.Size(146, 20)
        Me.TextBox81.TabIndex = 64
        Me.TextBox81.Text = "TRUE"
        Me.TextBox81.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox82
        '
        Me.TextBox82.Location = New System.Drawing.Point(311, 32)
        Me.TextBox82.Name = "TextBox82"
        Me.TextBox82.Size = New System.Drawing.Size(146, 20)
        Me.TextBox82.TabIndex = 63
        Me.TextBox82.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox83
        '
        Me.TextBox83.Location = New System.Drawing.Point(159, 32)
        Me.TextBox83.Name = "TextBox83"
        Me.TextBox83.Size = New System.Drawing.Size(146, 20)
        Me.TextBox83.TabIndex = 62
        Me.TextBox83.Text = "TRUE"
        Me.TextBox83.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox84
        '
        Me.TextBox84.Location = New System.Drawing.Point(6, 32)
        Me.TextBox84.Name = "TextBox84"
        Me.TextBox84.Size = New System.Drawing.Size(147, 20)
        Me.TextBox84.TabIndex = 61
        Me.TextBox84.Text = "D0661_CMD_ON"
        Me.TextBox84.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox76
        '
        Me.TextBox76.Location = New System.Drawing.Point(617, 5)
        Me.TextBox76.Name = "TextBox76"
        Me.TextBox76.Size = New System.Drawing.Size(140, 20)
        Me.TextBox76.TabIndex = 50
        Me.TextBox76.Text = "TEST STATUS"
        Me.TextBox76.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox77
        '
        Me.TextBox77.Location = New System.Drawing.Point(461, 5)
        Me.TextBox77.Name = "TextBox77"
        Me.TextBox77.Size = New System.Drawing.Size(150, 20)
        Me.TextBox77.TabIndex = 49
        Me.TextBox77.Text = "LOW LIMIT"
        Me.TextBox77.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox78
        '
        Me.TextBox78.Location = New System.Drawing.Point(311, 6)
        Me.TextBox78.Name = "TextBox78"
        Me.TextBox78.Size = New System.Drawing.Size(146, 20)
        Me.TextBox78.TabIndex = 48
        Me.TextBox78.Text = "MEASURED"
        Me.TextBox78.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox79
        '
        Me.TextBox79.Location = New System.Drawing.Point(159, 6)
        Me.TextBox79.Name = "TextBox79"
        Me.TextBox79.Size = New System.Drawing.Size(146, 20)
        Me.TextBox79.TabIndex = 47
        Me.TextBox79.Text = "HIGH LIMIT"
        Me.TextBox79.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox80
        '
        Me.TextBox80.Location = New System.Drawing.Point(6, 6)
        Me.TextBox80.Name = "TextBox80"
        Me.TextBox80.Size = New System.Drawing.Size(147, 20)
        Me.TextBox80.TabIndex = 46
        Me.TextBox80.Text = "PARAMETER"
        Me.TextBox80.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TabPage10
        '
        Me.TabPage10.Controls.Add(Me.Button37)
        Me.TabPage10.Controls.Add(Me.TextBox125)
        Me.TabPage10.Controls.Add(Me.TextBox126)
        Me.TabPage10.Controls.Add(Me.TextBox127)
        Me.TabPage10.Controls.Add(Me.TextBox128)
        Me.TabPage10.Controls.Add(Me.TextBox129)
        Me.TabPage10.Controls.Add(Me.TextBox130)
        Me.TabPage10.Controls.Add(Me.TextBox131)
        Me.TabPage10.Controls.Add(Me.TextBox132)
        Me.TabPage10.Controls.Add(Me.TextBox133)
        Me.TabPage10.Location = New System.Drawing.Point(4, 22)
        Me.TabPage10.Name = "TabPage10"
        Me.TabPage10.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage10.Size = New System.Drawing.Size(779, 119)
        Me.TabPage10.TabIndex = 4
        Me.TabPage10.Text = "TIME"
        Me.TabPage10.UseVisualStyleBackColor = True
        '
        'Button37
        '
        Me.Button37.Location = New System.Drawing.Point(617, 29)
        Me.Button37.Name = "Button37"
        Me.Button37.Size = New System.Drawing.Size(140, 23)
        Me.Button37.TabIndex = 75
        Me.Button37.UseVisualStyleBackColor = True
        '
        'TextBox125
        '
        Me.TextBox125.Location = New System.Drawing.Point(465, 31)
        Me.TextBox125.Name = "TextBox125"
        Me.TextBox125.Size = New System.Drawing.Size(146, 20)
        Me.TextBox125.TabIndex = 74
        Me.TextBox125.Text = "TRUE"
        Me.TextBox125.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox126
        '
        Me.TextBox126.Location = New System.Drawing.Point(311, 31)
        Me.TextBox126.Name = "TextBox126"
        Me.TextBox126.Size = New System.Drawing.Size(146, 20)
        Me.TextBox126.TabIndex = 73
        Me.TextBox126.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox127
        '
        Me.TextBox127.Location = New System.Drawing.Point(159, 31)
        Me.TextBox127.Name = "TextBox127"
        Me.TextBox127.Size = New System.Drawing.Size(146, 20)
        Me.TextBox127.TabIndex = 72
        Me.TextBox127.Text = "TRUE"
        Me.TextBox127.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox128
        '
        Me.TextBox128.Location = New System.Drawing.Point(6, 31)
        Me.TextBox128.Name = "TextBox128"
        Me.TextBox128.Size = New System.Drawing.Size(147, 20)
        Me.TextBox128.TabIndex = 71
        Me.TextBox128.Text = "SET UNIT TIME"
        Me.TextBox128.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox129
        '
        Me.TextBox129.Location = New System.Drawing.Point(617, 4)
        Me.TextBox129.Name = "TextBox129"
        Me.TextBox129.Size = New System.Drawing.Size(140, 20)
        Me.TextBox129.TabIndex = 70
        Me.TextBox129.Text = "TEST STATUS"
        Me.TextBox129.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox130
        '
        Me.TextBox130.Location = New System.Drawing.Point(461, 4)
        Me.TextBox130.Name = "TextBox130"
        Me.TextBox130.Size = New System.Drawing.Size(150, 20)
        Me.TextBox130.TabIndex = 69
        Me.TextBox130.Text = "LOW LIMIT"
        Me.TextBox130.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox131
        '
        Me.TextBox131.Location = New System.Drawing.Point(311, 5)
        Me.TextBox131.Name = "TextBox131"
        Me.TextBox131.Size = New System.Drawing.Size(146, 20)
        Me.TextBox131.TabIndex = 68
        Me.TextBox131.Text = "MEASURED"
        Me.TextBox131.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox132
        '
        Me.TextBox132.Location = New System.Drawing.Point(159, 5)
        Me.TextBox132.Name = "TextBox132"
        Me.TextBox132.Size = New System.Drawing.Size(146, 20)
        Me.TextBox132.TabIndex = 67
        Me.TextBox132.Text = "HIGH LIMIT"
        Me.TextBox132.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox133
        '
        Me.TextBox133.Location = New System.Drawing.Point(6, 5)
        Me.TextBox133.Name = "TextBox133"
        Me.TextBox133.Size = New System.Drawing.Size(147, 20)
        Me.TextBox133.TabIndex = 66
        Me.TextBox133.Text = "PARAMETER"
        Me.TextBox133.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TabPage11
        '
        Me.TabPage11.Controls.Add(Me.Button38)
        Me.TabPage11.Controls.Add(Me.TextBox134)
        Me.TabPage11.Controls.Add(Me.TextBox135)
        Me.TabPage11.Controls.Add(Me.TextBox136)
        Me.TabPage11.Controls.Add(Me.TextBox137)
        Me.TabPage11.Controls.Add(Me.TextBox138)
        Me.TabPage11.Controls.Add(Me.TextBox139)
        Me.TabPage11.Controls.Add(Me.TextBox140)
        Me.TabPage11.Controls.Add(Me.TextBox141)
        Me.TabPage11.Controls.Add(Me.TextBox142)
        Me.TabPage11.Location = New System.Drawing.Point(4, 22)
        Me.TabPage11.Name = "TabPage11"
        Me.TabPage11.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage11.Size = New System.Drawing.Size(779, 119)
        Me.TabPage11.TabIndex = 5
        Me.TabPage11.Text = "STEPPER "
        Me.TabPage11.UseVisualStyleBackColor = True
        '
        'Button38
        '
        Me.Button38.Location = New System.Drawing.Point(632, 32)
        Me.Button38.Name = "Button38"
        Me.Button38.Size = New System.Drawing.Size(140, 23)
        Me.Button38.TabIndex = 85
        Me.Button38.UseVisualStyleBackColor = True
        '
        'TextBox134
        '
        Me.TextBox134.Location = New System.Drawing.Point(480, 34)
        Me.TextBox134.Name = "TextBox134"
        Me.TextBox134.Size = New System.Drawing.Size(146, 20)
        Me.TextBox134.TabIndex = 84
        Me.TextBox134.Text = "TRUE"
        Me.TextBox134.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox135
        '
        Me.TextBox135.Location = New System.Drawing.Point(326, 34)
        Me.TextBox135.Name = "TextBox135"
        Me.TextBox135.Size = New System.Drawing.Size(146, 20)
        Me.TextBox135.TabIndex = 83
        Me.TextBox135.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox136
        '
        Me.TextBox136.Location = New System.Drawing.Point(174, 34)
        Me.TextBox136.Name = "TextBox136"
        Me.TextBox136.Size = New System.Drawing.Size(146, 20)
        Me.TextBox136.TabIndex = 82
        Me.TextBox136.Text = "TRUE"
        Me.TextBox136.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox137
        '
        Me.TextBox137.Location = New System.Drawing.Point(21, 34)
        Me.TextBox137.Name = "TextBox137"
        Me.TextBox137.Size = New System.Drawing.Size(147, 20)
        Me.TextBox137.TabIndex = 81
        Me.TextBox137.Text = "CMD_STEPPER ON"
        Me.TextBox137.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox138
        '
        Me.TextBox138.Location = New System.Drawing.Point(632, 7)
        Me.TextBox138.Name = "TextBox138"
        Me.TextBox138.Size = New System.Drawing.Size(140, 20)
        Me.TextBox138.TabIndex = 80
        Me.TextBox138.Text = "TEST STATUS"
        Me.TextBox138.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox139
        '
        Me.TextBox139.Location = New System.Drawing.Point(476, 7)
        Me.TextBox139.Name = "TextBox139"
        Me.TextBox139.Size = New System.Drawing.Size(150, 20)
        Me.TextBox139.TabIndex = 79
        Me.TextBox139.Text = "LOW LIMIT"
        Me.TextBox139.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox140
        '
        Me.TextBox140.Location = New System.Drawing.Point(326, 8)
        Me.TextBox140.Name = "TextBox140"
        Me.TextBox140.Size = New System.Drawing.Size(146, 20)
        Me.TextBox140.TabIndex = 78
        Me.TextBox140.Text = "MEASURED"
        Me.TextBox140.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox141
        '
        Me.TextBox141.Location = New System.Drawing.Point(174, 8)
        Me.TextBox141.Name = "TextBox141"
        Me.TextBox141.Size = New System.Drawing.Size(146, 20)
        Me.TextBox141.TabIndex = 77
        Me.TextBox141.Text = "HIGH LIMIT"
        Me.TextBox141.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox142
        '
        Me.TextBox142.Location = New System.Drawing.Point(21, 8)
        Me.TextBox142.Name = "TextBox142"
        Me.TextBox142.Size = New System.Drawing.Size(147, 20)
        Me.TextBox142.TabIndex = 76
        Me.TextBox142.Text = "PARAMETER"
        Me.TextBox142.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TabPage12
        '
        Me.TabPage12.Controls.Add(Me.Button39)
        Me.TabPage12.Controls.Add(Me.TextBox143)
        Me.TabPage12.Controls.Add(Me.TextBox144)
        Me.TabPage12.Controls.Add(Me.TextBox145)
        Me.TabPage12.Controls.Add(Me.TextBox146)
        Me.TabPage12.Controls.Add(Me.TextBox147)
        Me.TabPage12.Controls.Add(Me.TextBox148)
        Me.TabPage12.Controls.Add(Me.TextBox149)
        Me.TabPage12.Controls.Add(Me.TextBox150)
        Me.TabPage12.Controls.Add(Me.TextBox151)
        Me.TabPage12.Location = New System.Drawing.Point(4, 22)
        Me.TabPage12.Name = "TabPage12"
        Me.TabPage12.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage12.Size = New System.Drawing.Size(779, 119)
        Me.TabPage12.TabIndex = 6
        Me.TabPage12.Text = "SHUT DOWN"
        Me.TabPage12.UseVisualStyleBackColor = True
        '
        'Button39
        '
        Me.Button39.Location = New System.Drawing.Point(617, 30)
        Me.Button39.Name = "Button39"
        Me.Button39.Size = New System.Drawing.Size(140, 23)
        Me.Button39.TabIndex = 95
        Me.Button39.UseVisualStyleBackColor = True
        '
        'TextBox143
        '
        Me.TextBox143.Location = New System.Drawing.Point(465, 32)
        Me.TextBox143.Name = "TextBox143"
        Me.TextBox143.Size = New System.Drawing.Size(146, 20)
        Me.TextBox143.TabIndex = 94
        Me.TextBox143.Text = "TRUE"
        Me.TextBox143.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox144
        '
        Me.TextBox144.Location = New System.Drawing.Point(311, 32)
        Me.TextBox144.Name = "TextBox144"
        Me.TextBox144.Size = New System.Drawing.Size(146, 20)
        Me.TextBox144.TabIndex = 93
        Me.TextBox144.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox145
        '
        Me.TextBox145.Location = New System.Drawing.Point(159, 32)
        Me.TextBox145.Name = "TextBox145"
        Me.TextBox145.Size = New System.Drawing.Size(146, 20)
        Me.TextBox145.TabIndex = 92
        Me.TextBox145.Text = "TRUE"
        Me.TextBox145.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox146
        '
        Me.TextBox146.Location = New System.Drawing.Point(6, 32)
        Me.TextBox146.Name = "TextBox146"
        Me.TextBox146.Size = New System.Drawing.Size(147, 20)
        Me.TextBox146.TabIndex = 91
        Me.TextBox146.Text = "SHUTDOWN"
        Me.TextBox146.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox147
        '
        Me.TextBox147.Location = New System.Drawing.Point(617, 5)
        Me.TextBox147.Name = "TextBox147"
        Me.TextBox147.Size = New System.Drawing.Size(140, 20)
        Me.TextBox147.TabIndex = 90
        Me.TextBox147.Text = "TEST STATUS"
        Me.TextBox147.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox148
        '
        Me.TextBox148.Location = New System.Drawing.Point(461, 5)
        Me.TextBox148.Name = "TextBox148"
        Me.TextBox148.Size = New System.Drawing.Size(150, 20)
        Me.TextBox148.TabIndex = 89
        Me.TextBox148.Text = "LOW LIMIT"
        Me.TextBox148.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox149
        '
        Me.TextBox149.Location = New System.Drawing.Point(311, 6)
        Me.TextBox149.Name = "TextBox149"
        Me.TextBox149.Size = New System.Drawing.Size(146, 20)
        Me.TextBox149.TabIndex = 88
        Me.TextBox149.Text = "MEASURED"
        Me.TextBox149.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox150
        '
        Me.TextBox150.Location = New System.Drawing.Point(159, 6)
        Me.TextBox150.Name = "TextBox150"
        Me.TextBox150.Size = New System.Drawing.Size(146, 20)
        Me.TextBox150.TabIndex = 87
        Me.TextBox150.Text = "HIGH LIMIT"
        Me.TextBox150.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox151
        '
        Me.TextBox151.Location = New System.Drawing.Point(6, 6)
        Me.TextBox151.Name = "TextBox151"
        Me.TextBox151.Size = New System.Drawing.Size(147, 20)
        Me.TextBox151.TabIndex = 86
        Me.TextBox151.Text = "PARAMETER"
        Me.TextBox151.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(801, 565)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "HPC"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(801, 565)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "UL SSMC"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TextBox16)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Button7)
        Me.GroupBox4.Controls.Add(Me.Button6)
        Me.GroupBox4.Controls.Add(Me.Button5)
        Me.GroupBox4.Controls.Add(Me.Button4)
        Me.GroupBox4.Controls.Add(Me.Button2)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 481)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 137)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "MANUAL MODE"
        '
        'TextBox16
        '
        Me.TextBox16.Location = New System.Drawing.Point(62, 111)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(124, 20)
        Me.TextBox16.TabIndex = 10
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(10, 116)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(44, 13)
        Me.Label14.TabIndex = 9
        Me.Label14.Text = "MARK :"
        '
        'Button7
        '
        Me.Button7.BackgroundImage = Global.PLU_POWER_FCT.My.Resources.Resources.clock
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Bell MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button7.Location = New System.Drawing.Point(121, 15)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(45, 42)
        Me.Button7.TabIndex = 8
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.BackgroundImage = Global.PLU_POWER_FCT.My.Resources.Resources.reuse
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Bell MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button6.Location = New System.Drawing.Point(70, 63)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(45, 42)
        Me.Button6.TabIndex = 8
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackgroundImage = Global.PLU_POWER_FCT.My.Resources.Resources.delete
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Bell MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button5.Location = New System.Drawing.Point(12, 63)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(45, 42)
        Me.Button5.TabIndex = 8
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.PLU_POWER_FCT.My.Resources.Resources.pause
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Bell MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(70, 15)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(45, 42)
        Me.Button4.TabIndex = 8
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.PLU_POWER_FCT.My.Resources.Resources.play_button_arrowhead
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Bell MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(12, 15)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(45, 42)
        Me.Button2.TabIndex = 8
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Window
        Me.Label10.Font = New System.Drawing.Font("Bell MT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(1025, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 14)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Label10"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Window
        Me.Label11.Font = New System.Drawing.Font("Bell MT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(945, 7)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 14)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "TESTER ID :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(356, 729)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 13)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "DESIGNATION :"
        '
        'Timer2
        '
        '
        'Timer3
        '
        '
        'StartTimer3
        '
        Me.StartTimer3.AutoSize = True
        Me.StartTimer3.Location = New System.Drawing.Point(697, 713)
        Me.StartTimer3.Name = "StartTimer3"
        Me.StartTimer3.Size = New System.Drawing.Size(79, 17)
        Me.StartTimer3.TabIndex = 14
        Me.StartTimer3.TabStop = True
        Me.StartTimer3.Text = "StartTimer3"
        Me.StartTimer3.UseVisualStyleBackColor = True
        '
        'StopTimer
        '
        Me.StopTimer.AutoSize = True
        Me.StopTimer.Location = New System.Drawing.Point(788, 713)
        Me.StopTimer.Name = "StopTimer"
        Me.StopTimer.Size = New System.Drawing.Size(79, 17)
        Me.StopTimer.TabIndex = 14
        Me.StopTimer.TabStop = True
        Me.StopTimer.Text = "StopTimer3"
        Me.StopTimer.UseVisualStyleBackColor = True
        '
        'ResetTimer
        '
        Me.ResetTimer.AutoSize = True
        Me.ResetTimer.Location = New System.Drawing.Point(873, 713)
        Me.ResetTimer.Name = "ResetTimer"
        Me.ResetTimer.Size = New System.Drawing.Size(85, 17)
        Me.ResetTimer.TabIndex = 14
        Me.ResetTimer.TabStop = True
        Me.ResetTimer.Text = "ResetTimer3"
        Me.ResetTimer.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(608, 711)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(75, 17)
        Me.CheckBox1.TabIndex = 15
        Me.CheckBox1.Text = "SLTRACK"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'MAIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.ControlBox = False
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.ResetTimer)
        Me.Controls.Add(Me.StopTimer)
        Me.Controls.Add(Me.StartTimer3)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MAIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MAIN TEST FORM"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        Me.TabPage8.ResumeLayout(False)
        Me.TabPage8.PerformLayout()
        Me.TabPage10.ResumeLayout(False)
        Me.TabPage10.PerformLayout()
        Me.TabPage11.ResumeLayout(False)
        Me.TabPage11.PerformLayout()
        Me.TabPage12.ResumeLayout(False)
        Me.TabPage12.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FILEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LOGINToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LOGOUTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EXITToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EDITToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VIEWToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SETTINGSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ABOUTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ConfrigurationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents CREATEUSERToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents REMOVEUSERToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CHANGEPASSWORDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FIRSTPASSYIELDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FINALPASSYIELDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HELPToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SETUPToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents ABOUTSOFTWAREToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents ENABLEMANUALMODEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button8 As Button
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox15 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents UPDATEDESIGNATIONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Button9 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Button11 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents TextBox16 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Timer2 As Windows.Forms.Timer
    Friend WithEvents Timer3 As Windows.Forms.Timer
    Friend WithEvents StartTimer3 As RadioButton
    Friend WithEvents StopTimer As RadioButton
    Friend WithEvents ResetTimer As RadioButton
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button12 As Button
    Friend WithEvents TextBox17 As TextBox
    Friend WithEvents TextBox18 As TextBox
    Friend WithEvents TextBox19 As TextBox
    Friend WithEvents TextBox20 As TextBox
    Friend WithEvents TextBox21 As TextBox
    Friend WithEvents TextBox22 As TextBox
    Friend WithEvents TextBox23 As TextBox
    Friend WithEvents TextBox24 As TextBox
    Friend WithEvents TextBox25 As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button13 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Button15 As Button
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents Button17 As Button
    Friend WithEvents TextBox38 As TextBox
    Friend WithEvents Button16 As Button
    Friend WithEvents TextBox37 As TextBox
    Friend WithEvents TextBox26 As TextBox
    Friend WithEvents TextBox36 As TextBox
    Friend WithEvents TextBox27 As TextBox
    Friend WithEvents TextBox35 As TextBox
    Friend WithEvents TextBox28 As TextBox
    Friend WithEvents TextBox29 As TextBox
    Friend WithEvents TextBox30 As TextBox
    Friend WithEvents TextBox31 As TextBox
    Friend WithEvents TextBox32 As TextBox
    Friend WithEvents TextBox33 As TextBox
    Friend WithEvents TextBox34 As TextBox
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents TabPage8 As TabPage
    Friend WithEvents TabPage10 As TabPage
    Friend WithEvents TabPage11 As TabPage
    Friend WithEvents TabPage12 As TabPage
    Friend WithEvents Button25 As Button
    Friend WithEvents TextBox75 As TextBox
    Friend WithEvents Button24 As Button
    Friend WithEvents TextBox74 As TextBox
    Friend WithEvents TextBox68 As TextBox
    Friend WithEvents TextBox73 As TextBox
    Friend WithEvents TextBox69 As TextBox
    Friend WithEvents TextBox72 As TextBox
    Friend WithEvents TextBox70 As TextBox
    Friend WithEvents TextBox71 As TextBox
    Friend WithEvents Button23 As Button
    Friend WithEvents TextBox67 As TextBox
    Friend WithEvents Button22 As Button
    Friend WithEvents TextBox63 As TextBox
    Friend WithEvents Button21 As Button
    Friend WithEvents TextBox59 As TextBox
    Friend WithEvents Button20 As Button
    Friend WithEvents TextBox66 As TextBox
    Friend WithEvents TextBox55 As TextBox
    Friend WithEvents TextBox62 As TextBox
    Friend WithEvents Button18 As Button
    Friend WithEvents TextBox58 As TextBox
    Friend WithEvents TextBox39 As TextBox
    Friend WithEvents TextBox65 As TextBox
    Friend WithEvents TextBox54 As TextBox
    Friend WithEvents TextBox61 As TextBox
    Friend WithEvents Button19 As Button
    Friend WithEvents TextBox57 As TextBox
    Friend WithEvents TextBox40 As TextBox
    Friend WithEvents TextBox64 As TextBox
    Friend WithEvents TextBox53 As TextBox
    Friend WithEvents TextBox60 As TextBox
    Friend WithEvents TextBox41 As TextBox
    Friend WithEvents TextBox56 As TextBox
    Friend WithEvents TextBox42 As TextBox
    Friend WithEvents TextBox52 As TextBox
    Friend WithEvents TextBox43 As TextBox
    Friend WithEvents TextBox44 As TextBox
    Friend WithEvents TextBox45 As TextBox
    Friend WithEvents TextBox46 As TextBox
    Friend WithEvents TextBox47 As TextBox
    Friend WithEvents TextBox48 As TextBox
    Friend WithEvents TextBox49 As TextBox
    Friend WithEvents TextBox50 As TextBox
    Friend WithEvents TextBox51 As TextBox
    Friend WithEvents TextBox76 As TextBox
    Friend WithEvents TextBox77 As TextBox
    Friend WithEvents TextBox78 As TextBox
    Friend WithEvents TextBox79 As TextBox
    Friend WithEvents TextBox80 As TextBox
    Friend WithEvents Button36 As Button
    Friend WithEvents TextBox124 As TextBox
    Friend WithEvents Button35 As Button
    Friend WithEvents TextBox120 As TextBox
    Friend WithEvents Button34 As Button
    Friend WithEvents TextBox116 As TextBox
    Friend WithEvents Button33 As Button
    Friend WithEvents TextBox112 As TextBox
    Friend WithEvents Button32 As Button
    Friend WithEvents TextBox108 As TextBox
    Friend WithEvents TextBox123 As TextBox
    Friend WithEvents Button31 As Button
    Friend WithEvents TextBox119 As TextBox
    Friend WithEvents TextBox104 As TextBox
    Friend WithEvents TextBox115 As TextBox
    Friend WithEvents Button30 As Button
    Friend WithEvents TextBox111 As TextBox
    Friend WithEvents TextBox100 As TextBox
    Friend WithEvents TextBox107 As TextBox
    Friend WithEvents TextBox122 As TextBox
    Friend WithEvents Button29 As Button
    Friend WithEvents TextBox118 As TextBox
    Friend WithEvents TextBox103 As TextBox
    Friend WithEvents TextBox114 As TextBox
    Friend WithEvents TextBox96 As TextBox
    Friend WithEvents TextBox110 As TextBox
    Friend WithEvents TextBox99 As TextBox
    Friend WithEvents TextBox106 As TextBox
    Friend WithEvents TextBox121 As TextBox
    Friend WithEvents Button28 As Button
    Friend WithEvents TextBox117 As TextBox
    Friend WithEvents TextBox102 As TextBox
    Friend WithEvents TextBox113 As TextBox
    Friend WithEvents TextBox95 As TextBox
    Friend WithEvents TextBox109 As TextBox
    Friend WithEvents TextBox98 As TextBox
    Friend WithEvents TextBox105 As TextBox
    Friend WithEvents TextBox89 As TextBox
    Friend WithEvents TextBox101 As TextBox
    Friend WithEvents TextBox94 As TextBox
    Friend WithEvents TextBox97 As TextBox
    Friend WithEvents TextBox90 As TextBox
    Friend WithEvents TextBox93 As TextBox
    Friend WithEvents TextBox91 As TextBox
    Friend WithEvents TextBox92 As TextBox
    Friend WithEvents Button27 As Button
    Friend WithEvents TextBox85 As TextBox
    Friend WithEvents TextBox86 As TextBox
    Friend WithEvents TextBox87 As TextBox
    Friend WithEvents TextBox88 As TextBox
    Friend WithEvents Button26 As Button
    Friend WithEvents TextBox81 As TextBox
    Friend WithEvents TextBox82 As TextBox
    Friend WithEvents TextBox83 As TextBox
    Friend WithEvents TextBox84 As TextBox
    Friend WithEvents Button37 As Button
    Friend WithEvents TextBox125 As TextBox
    Friend WithEvents TextBox126 As TextBox
    Friend WithEvents TextBox127 As TextBox
    Friend WithEvents TextBox128 As TextBox
    Friend WithEvents TextBox129 As TextBox
    Friend WithEvents TextBox130 As TextBox
    Friend WithEvents TextBox131 As TextBox
    Friend WithEvents TextBox132 As TextBox
    Friend WithEvents TextBox133 As TextBox
    Friend WithEvents Button38 As Button
    Friend WithEvents TextBox134 As TextBox
    Friend WithEvents TextBox135 As TextBox
    Friend WithEvents TextBox136 As TextBox
    Friend WithEvents TextBox137 As TextBox
    Friend WithEvents TextBox138 As TextBox
    Friend WithEvents TextBox139 As TextBox
    Friend WithEvents TextBox140 As TextBox
    Friend WithEvents TextBox141 As TextBox
    Friend WithEvents TextBox142 As TextBox
    Friend WithEvents Button39 As Button
    Friend WithEvents TextBox143 As TextBox
    Friend WithEvents TextBox144 As TextBox
    Friend WithEvents TextBox145 As TextBox
    Friend WithEvents TextBox146 As TextBox
    Friend WithEvents TextBox147 As TextBox
    Friend WithEvents TextBox148 As TextBox
    Friend WithEvents TextBox149 As TextBox
    Friend WithEvents TextBox150 As TextBox
    Friend WithEvents TextBox151 As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button40 As Button
    Friend WithEvents TextBox152 As TextBox
End Class

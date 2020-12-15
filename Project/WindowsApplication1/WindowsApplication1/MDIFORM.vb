Imports System.Windows.Forms
Public Class MDIFORM

    Private Sub PPPLToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PPPLToolStripMenuItem.Click
        Dim f As New PLANTS()
        f.MdiParent = Me
        f.Dock = DockStyle.Fill
        f.Show()
    End Sub

    Private Sub MDIFORM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub VENDORToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VENDORToolStripMenuItem.Click
        Dim f As New VENDOR()
        f.MdiParent = Me
        f.Dock = DockStyle.Fill
        f.Show()

    End Sub

    Private Sub SUPPLIERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SUPPLIERToolStripMenuItem.Click
        Dim f As New SUPPLIER()
        f.MdiParent = Me
        f.Dock = DockStyle.Fill
        f.Show()

    End Sub

    Private Sub PURCHASEINVOICEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PURCHASEINVOICEToolStripMenuItem.Click
        Dim f As New PURCHASE_INVOICE()
        f.MdiParent = Me
        f.Dock = DockStyle.Fill
        f.Show()

    End Sub

    Private Sub SALESINVOICEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SALESINVOICEToolStripMenuItem.Click
        Dim f As New SALES_INVOICE()
        f.MdiParent = Me
        f.Dock = DockStyle.Fill
        f.Show()

    End Sub

    Private Sub DELIVERYToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DELIVERYToolStripMenuItem.Click
        Dim f As New DELIVERY()
        f.MdiParent = Me
        f.Dock = DockStyle.Fill
        f.Show()

    End Sub
    Private Sub PAYMENTToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PAYMENTToolStripMenuItem1.Click
        Dim f As New PAYMENT_SUPPLIERS_FORM()
        f.MdiParent = Me
        f.Dock = DockStyle.Fill
        f.Show()

    End Sub

    Private Sub PAYMENTVIEWToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PAYMENTVIEWToolStripMenuItem.Click
        Dim f As New PAYMENT_SUPPLIERS_VIEW()
        f.MdiParent = Me
        f.Dock = DockStyle.Fill
        f.Show()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Hide()
    End Sub

    Private Sub CUSTOMERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CUSTOMERToolStripMenuItem.Click
        Dim f As New CUSTOMER_FORM()
        f.MdiParent = Me
        f.Dock = DockStyle.Fill
        f.Show()
    End Sub
End Class


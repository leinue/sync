Public Class Form1
    Dim ab As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Function GetEle(ByVal syn_dif As String) As String() 'act as structure
        Dim a() As String
        a = Split(syn_dif, ",")
        Return a
    End Function

    Function syncretism(ByVal synf1 As String, synf2 As String) As String
        Dim syn_fn() As String
        If attr_IsSame(synf1, synf2) = True Then

            syn_fn = GetEle(dif(synf1, synf2))
            Return syn_fn(0) + "与" + syn_fn(1) + "有" + ab + "的关系"
        Else
            Return ""
        End If
    End Function

    Function GetAttr(ByVal fn As String) As String '获得事件名称
        Dim attr_len As Integer '事件长度
        Dim attr_result As String = ""

        attr_len = fn.LastIndexOf("(")
        attr_result = fn.Remove(attr_len, fn.Length() - attr_len)

        ab = attr_result

        Return attr_result
    End Function

    Function dif(ByVal f1 As String, f2 As String) As String 'NULL失败,并且只针对不同的两个句子!@important
        Dim i As Integer = 0
        Dim j1 As Integer = 0
        Dim j2 As Integer = 0
        Dim t_f1 As String = ""
        Dim t_f2 As String = ""

        If f1 <> "" And f2 <> "" Then
            While f1.ElementAt(i) = f2.ElementAt(i)
                i += 1
            End While

            j1 = i
            While j1 < f1.Length() - 1 And f1.ElementAt(j1) <> ","
                ' p(a,y)  p(x,y)
                j1 += 1
                t_f1 = f1.Remove(j1, f1.Length() - j1)
                t_f1 = t_f1.Replace(GetAttr(f1) + "(", "") '不同的部分
            End While

            j2 = i
            While j2 < f2.Length() - 1 And f2.ElementAt(j2) <> ","
                ' p(a,y)  p(x,y)
                j2 += 1
                t_f2 = f2.Remove(j2, f2.Length() - j2)
                t_f2 = t_f2.Replace(GetAttr(f2) + "(", "") '不同的部分
            End While

            Return t_f1 + "," + t_f2
        Else
            Return ""
        End If

        Return ""
    End Function

    Function attr_IsSame(ByVal attr_f1 As String, attr_f2 As String) As Boolean '事件是否相同
        Dim atf1 As String = ""
        Dim atf2 As String = ""

        atf1 = GetAttr(attr_f1)
        atf2 = GetAttr(attr_f2)

        If atf1 = atf2 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Debug.WriteLine(syncretism("p(a,y)", "p(x,y)"))
        TextBox3.Text += syncretism("p(a,y)", "p(x,y)")
    End Sub
End Class

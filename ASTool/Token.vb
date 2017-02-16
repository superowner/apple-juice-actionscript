﻿Public Class Token
    Public Enum TokenType
        ''' <summary>
        ''' 标识符
        ''' </summary>
        ''' <remarks></remarks>
        identifier

        ''' <summary>
        ''' 字符串常量
        ''' </summary>
        ''' <remarks></remarks>
        const_string
        ''' <summary>
        ''' 数值常量
        ''' </summary>
        ''' <remarks></remarks>
        const_number

        ''' <summary>
        ''' 注释
        ''' </summary>
        ''' <remarks></remarks>
        comments

        ''' <summary>
        ''' 空白
        ''' </summary>
        ''' <remarks></remarks>
        whitespace

        ''' <summary>
        ''' 文件尾
        ''' </summary>
        ''' <remarks></remarks>
        eof


        ''' <summary>
        ''' 其他
        ''' </summary>
        ''' <remarks></remarks>
        other


    End Enum
    ''' <summary>
    ''' 结束符
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared TokenEOF As New Token() With {.Type = TokenType.eof}


    Public Sub New()
        Type = TokenType.other
        StringValue = String.Empty
    End Sub


    Public Type As TokenType

    Public line As Integer

    Public ptr As Integer

    ''' <summary>
    ''' 字符串值
    ''' </summary>
    ''' <remarks></remarks>
    Public StringValue As String

    ''' <summary>
    ''' 源文件
    ''' </summary>
    ''' <remarks></remarks>
    Public sourceFile As String

End Class
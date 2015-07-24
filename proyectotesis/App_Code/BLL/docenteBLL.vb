Imports Proyecto3capa
Imports Proyecto3capaTableAdapters


<System.ComponentModel.DataObject()> _
Public Class docenteBLL

    Private _docenteAdapter As docentesTableAdapter = Nothing
    Protected ReadOnly Property Adapter() As docentesTableAdapter
        Get
            If _docenteAdapter Is Nothing Then
                _docenteAdapter = New docentesTableAdapter()
            End If

            Return _docenteAdapter
        End Get
    End Property

    <System.ComponentModel.DataObjectMethodAttribute _
            (System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function Getdocentes() As docentesDataTable
        Return Adapter.Getdocentes()
    End Function


    <System.ComponentModel.DataObjectMethodAttribute _
        (System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function GetdocentebyCI(ByVal CI As String) _
        As Proyecto3capa.docentesDataTable
        Return Adapter.GetdocentebyCI(CI)
    End Function

    <System.ComponentModel.DataObjectMethodAttribute _
        (System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function GetdocentebyNombre(ByVal Nombre As String) _
               As Proyecto3capa.docentesDataTable
        Return Adapter.GetdocentebyNombre(Nombre)
    End Function

    <System.ComponentModel.DataObjectMethodAttribute _
           (System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function GetdocentebyApellido(ByVal Apellido As String) _
               As Proyecto3capa.docentesDataTable
        Return Adapter.GetdocentebyApellido(Apellido)
    End Function



    <System.ComponentModel.DataObjectMethodAttribute _
           (System.ComponentModel.DataObjectMethodType.Insert, True)> _
    Public Function InsertDocente( _
        ByVal CI As Integer, ByVal Nombre As Nullable(Of Integer), _
        ByVal Apellido As Nullable(Of Integer), ByVal Direccion As Nullable(Of Integer),
        ByVal Telefono As Nullable(Of Integer), ByVal email As Nullable(Of Integer), ByVal Especialidad As Nullable(Of Short)) As Integer

        Dim docentes As New Proyecto3capa.docentesDataTable()
        Dim docente As Proyecto3capa.docentesRow = docentes.NewdocentesRow()


        docente.CI = CI


        If Not Nombre.HasValue Then
            docente.SetNombreNull()
        Else
            docente.Nombre = Nombre.Value
        End If


        If Not Apellido.HasValue Then
            docente.SetApellidoNull()
        Else
            docente.Apellido = Apellido.Value
        End If



        If Not Direccion Is Nothing Then
            docente.SetDireccionNull()
        Else
            docente.Direccion = Direccion
        End If



        If Not Direccion.HasValue Then
            docente.SetDireccionNull()
        Else
            docente.Direccion = Direccion.Value
        End If



        If Not Telefono.HasValue Then
            docente.SetTelefonoNull()
        Else
            docente.Telefono = Telefono.Value
        End If




        If Not email.HasValue Then
            docente.SetemailNull()
        Else
            docente.email = email.Value
        End If


        If Not Especialidad.HasValue Then
            docente.SetEspecialidadNull()
        Else
            docente.email = Especialidad.Value
        End If



        docente.CI = CI


        docentes.AdddocentesRow(docente)
        Dim rowsAffected As Integer = Adapter.Update(docente)

        Return rowsAffected = 1
    End Function





    <System.ComponentModel.DataObjectMethodAttribute _
        (System.ComponentModel.DataObjectMethodType.Update, True)> _
    Public Function UpdateDocente( _
        ByVal CI As Integer, ByVal Nombre As Nullable(Of Integer), _
        ByVal Apellido As Nullable(Of Integer), ByVal Direccion As Nullable(Of Integer),
        ByVal Telefono As Nullable(Of Integer), ByVal email As Nullable(Of Integer), ByVal Especialidad As Nullable(Of Short)) As Boolean

        Dim docentes As Proyecto3capa.docentesDataTable = _
            Adapter.GetdocentebyApellido(Apellido)

        If docentes.Count = 0 Then
            Return False
        End If

        Dim docente As Proyecto3capa.docentesRow = docentes(0)

        docente.CI = CI


        If Not Nombre.HasValue Then
            docente.SetNombreNull()
        Else
            docente.Nombre = Nombre.Value
        End If




        If Not Apellido.HasValue Then
            docente.SetApellidoNull()
        Else
            docente.Apellido = Apellido.Value
        End If




        If Not Direccion Is Nothing Then
            docente.SetDireccionNull()
        Else
            docente.Direccion = Direccion
        End If



        If Not Telefono.HasValue Then
            docente.SetTelefonoNull()
        Else
            docente.Telefono = Telefono.Value
        End If



        If Not email.HasValue Then
            docente.SetemailNull()
        Else
            docente.email = email.Value
        End If


        If Not Especialidad.HasValue Then
            docente.SetEspecialidadNull()
        Else
            docente.email = email.Value
        End If


        docente.CI = CI

        Dim rowsAffected As Integer = Adapter.Update(docente)

        Return rowsAffected = 1
    End Function

    <System.ComponentModel.DataObjectMethodAttribute _
        (System.ComponentModel.DataObjectMethodType.Delete, True)> _
    Public Function DeleteDocente(ByVal CI As Integer) As Boolean
        Dim rowsAffected As Integer = Adapter.Delete(CI)

        Return rowsAffected = 1
    End Function

End Class

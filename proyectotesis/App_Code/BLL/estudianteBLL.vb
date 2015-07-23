Imports Proyecto3capa
Imports Proyecto3capaTableAdapters



<System.ComponentModel.DataObject()> _
Public Class estudianteBLL

    Private _estudianteAdapter As estudiantesTableAdapter = Nothing
    Protected ReadOnly Property Adapter() As estudiantesTableAdapter
        Get
            If _estudianteAdapter Is Nothing Then
                _estudianteAdapter = New estudiantesTableAdapter()
            End If

            Return _estudianteAdapter
        End Get
    End Property

    <System.ComponentModel.DataObjectMethodAttribute _
            (System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function Getestudiantes() As estudiantesDataTable
        Return Adapter.Getestudiantes()
    End Function


    <System.ComponentModel.DataObjectMethodAttribute _
        (System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function GetestudiantebyCI(ByVal CI As String) _
        As Proyecto3capa.estudiantesDataTable
        Return Adapter.GetestudiantebyCI(CI)
    End Function

    <System.ComponentModel.DataObjectMethodAttribute _
        (System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function GetestudiantebyNombre(ByVal Nombre As String) _
               As Proyecto3capa.estudiantesDataTable
        Return Adapter.GetestudiantebyNombre(Nombre)
    End Function

    <System.ComponentModel.DataObjectMethodAttribute _
           (System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function GetestudiantebyApellido(ByVal Apellido As String) _
               As Proyecto3capa.estudiantesDataTable
        Return Adapter.GetestudiantebyApellido(Apellido)
    End Function



    <System.ComponentModel.DataObjectMethodAttribute _
           (System.ComponentModel.DataObjectMethodType.Insert, True)> _
    Public Function InsertEstudiante( _
        ByVal CI As Integer, ByVal Nombre As Nullable(Of Integer), _
        ByVal Apellido As Nullable(Of Short), ByVal Direccion As Nullable(Of Integer),
        ByVal Telefono As Nullable(Of Integer), ByVal email As Nullable(Of Integer), ByVal Carrera As Nullable(Of Short)) As Integer

        Dim estudiantes As New Proyecto3capa.estudiantesDataTable()
        Dim estudiante As Proyecto3capa.estudiantesRow = estudiantes.NewestudiantesRow()


        estudiante.CI = CI


        If Not Nombre.HasValue Then
            estudiante.SetNombreNull()
        Else
            estudiante.Nombre = Nombre.Value
        End If


        If Not Apellido.HasValue Then
            estudiante.SetApellidoNull()
        Else
            estudiante.Apellido = Apellido.Value
        End If



        If Not Direccion Is Nothing Then
            estudiante.SetDireccionNull()
        Else
            estudiante.Direccion = Direccion
        End If



        If Not Direccion.HasValue Then
            estudiante.SetDireccionNull()
        Else
            estudiante.Direccion = Direccion.Value
        End If



        If Not Telefono.HasValue Then
            estudiante.SetTelefonoNull()
        Else
            estudiante.Telefono = Telefono.Value
        End If




        If Not email.HasValue Then
            estudiante.SetemailNull()
        Else
            estudiante.email = email.Value
        End If


        If Not Carrera.HasValue Then
            estudiante.SetCarreraNull()
        Else
            estudiante.email = Carrera.Value
        End If



        estudiante.CI = CI


        estudiantes.AddestudiantesRow(estudiante)
        Dim rowsAffected As Integer = Adapter.Update(estudiante)

        Return rowsAffected = 1
    End Function





    <System.ComponentModel.DataObjectMethodAttribute _
        (System.ComponentModel.DataObjectMethodType.Update, True)> _
    Public Function UpdateEstudiantes( _
        ByVal CI As Integer, ByVal Nombre As Nullable(Of Integer), _
        ByVal Apellido As Nullable(Of Short), ByVal Direccion As Nullable(Of Integer),
        ByVal Telefono As Nullable(Of Integer), ByVal email As Nullable(Of Integer), ByVal Carrera As Nullable(Of Short)) As Integer

        Dim estudiantes As Proyecto3capa.estudiantesDataTable = _
            Adapter.GetestudiantebyApellido(Apellido)

        If estudiantes.Count = 0 Then
            Return False
        End If

        Dim estudiante As Proyecto3capa.estudiantesRow = estudiantes(0)

        estudiante.CI = CI


        If Not Nombre.HasValue Then
            estudiante.SetNombreNull()
        Else
            estudiante.Nombre = Nombre.Value
        End If




        If Not Apellido.HasValue Then
            estudiante.SetApellidoNull()
        Else
            estudiante.Apellido = Apellido.Value
        End If




        If Not Direccion Is Nothing Then
            estudiante.SetDireccionNull()
        Else
            estudiante.Direccion = Direccion
        End If



        If Not Telefono.HasValue Then
            estudiante.SetTelefonoNull()
        Else
            estudiante.Telefono = Telefono.Value
        End If



        If Not email.HasValue Then
            estudiante.SetemailNull()
        Else
            estudiante.email = email.Value
        End If


        If Not Carrera.HasValue Then
            estudiante.SetCarreraNull()
        Else
            estudiante.email = email.Value
        End If


        estudiante.CI = CI

        Dim rowsAffected As Integer = Adapter.Update(estudiante)

        Return rowsAffected = 1
    End Function

    <System.ComponentModel.DataObjectMethodAttribute _
        (System.ComponentModel.DataObjectMethodType.Delete, True)> _
    Public Function DeleteEstudiante(ByVal CI As Integer) As Boolean

        Dim rowsAffected As Integer = Adapter.Delete(CI)

        Return rowsAffected = 1
    End Function

End Class

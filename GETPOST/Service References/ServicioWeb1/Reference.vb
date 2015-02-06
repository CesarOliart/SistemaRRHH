﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.18063
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace ServicioWeb1
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute([Namespace]:="http://ws.servicesweb.rrhhintegration.com/", ConfigurationName:="ServicioWeb1.TrabajadorWS")>  _
    Public Interface TrabajadorWS
        
        <System.ServiceModel.OperationContractAttribute(Action:="", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(Style:=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults:=true)>  _
        Function registrarTrabajador(ByVal trabajador As ServicioWeb1.trabajador) As <System.ServiceModel.MessageParameterAttribute(Name:="response")> String
        
        <System.ServiceModel.OperationContractAttribute(Action:="", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(Style:=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults:=true)>  _
        Function obtenerUno(ByVal codigoTrabajador As String) As <System.ServiceModel.MessageParameterAttribute(Name:="response")> ServicioWeb1.trabajador
        
        'CODEGEN: El parámetro 'response' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlArrayAttribute'.
        <System.ServiceModel.OperationContractAttribute(Action:="", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function obtenerTodos(ByVal request As ServicioWeb1.obtenerTodos) As <System.ServiceModel.MessageParameterAttribute(Name:="response")> ServicioWeb1.obtenerTodosResponse
        
        <System.ServiceModel.OperationContractAttribute(Action:="", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(Style:=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults:=true)>  _
        Function eliminarTrabajador(ByVal codigoTrabajador As String) As <System.ServiceModel.MessageParameterAttribute(Name:="response")> String
        
        <System.ServiceModel.OperationContractAttribute(Action:="", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(Style:=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults:=true)>  _
        Function actualizarTrabajador(ByVal trabajador As ServicioWeb1.trabajador) As <System.ServiceModel.MessageParameterAttribute(Name:="response")> String
    End Interface
    
    '''<comentarios/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://ws.servicesweb.rrhhintegration.com/")>  _
    Partial Public Class trabajador
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged
        
        Private apeMatField As String
        
        Private apePatField As String
        
        Private codigoAFPField As String
        
        Private codigoBancoAbonoField As String
        
        Private codigoDNIField As String
        
        Private codigoDepartamentoField As String
        
        Private codigoDistritoField As String
        
        Private codigoNacionalidadField As String
        
        Private codigoProvinciaField As String
        
        Private correoField As String
        
        Private direccionField As String
        
        Private estadoActivoField As String
        
        Private estadoCivilField As String
        
        Private nombresField As String
        
        Private numCUPSField As String
        
        Private sexoColaboradorField As String
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=0)>  _
        Public Property apeMat() As String
            Get
                Return Me.apeMatField
            End Get
            Set
                Me.apeMatField = value
                Me.RaisePropertyChanged("apeMat")
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=1)>  _
        Public Property apePat() As String
            Get
                Return Me.apePatField
            End Get
            Set
                Me.apePatField = value
                Me.RaisePropertyChanged("apePat")
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=2)>  _
        Public Property codigoAFP() As String
            Get
                Return Me.codigoAFPField
            End Get
            Set
                Me.codigoAFPField = value
                Me.RaisePropertyChanged("codigoAFP")
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=3)>  _
        Public Property codigoBancoAbono() As String
            Get
                Return Me.codigoBancoAbonoField
            End Get
            Set
                Me.codigoBancoAbonoField = value
                Me.RaisePropertyChanged("codigoBancoAbono")
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=4)>  _
        Public Property codigoDNI() As String
            Get
                Return Me.codigoDNIField
            End Get
            Set
                Me.codigoDNIField = value
                Me.RaisePropertyChanged("codigoDNI")
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=5)>  _
        Public Property codigoDepartamento() As String
            Get
                Return Me.codigoDepartamentoField
            End Get
            Set
                Me.codigoDepartamentoField = value
                Me.RaisePropertyChanged("codigoDepartamento")
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=6)>  _
        Public Property codigoDistrito() As String
            Get
                Return Me.codigoDistritoField
            End Get
            Set
                Me.codigoDistritoField = value
                Me.RaisePropertyChanged("codigoDistrito")
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=7)>  _
        Public Property codigoNacionalidad() As String
            Get
                Return Me.codigoNacionalidadField
            End Get
            Set
                Me.codigoNacionalidadField = value
                Me.RaisePropertyChanged("codigoNacionalidad")
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=8)>  _
        Public Property codigoProvincia() As String
            Get
                Return Me.codigoProvinciaField
            End Get
            Set
                Me.codigoProvinciaField = value
                Me.RaisePropertyChanged("codigoProvincia")
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=9)>  _
        Public Property correo() As String
            Get
                Return Me.correoField
            End Get
            Set
                Me.correoField = value
                Me.RaisePropertyChanged("correo")
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=10)>  _
        Public Property direccion() As String
            Get
                Return Me.direccionField
            End Get
            Set
                Me.direccionField = value
                Me.RaisePropertyChanged("direccion")
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=11)>  _
        Public Property estadoActivo() As String
            Get
                Return Me.estadoActivoField
            End Get
            Set
                Me.estadoActivoField = value
                Me.RaisePropertyChanged("estadoActivo")
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=12)>  _
        Public Property estadoCivil() As String
            Get
                Return Me.estadoCivilField
            End Get
            Set
                Me.estadoCivilField = value
                Me.RaisePropertyChanged("estadoCivil")
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=13)>  _
        Public Property nombres() As String
            Get
                Return Me.nombresField
            End Get
            Set
                Me.nombresField = value
                Me.RaisePropertyChanged("nombres")
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=14)>  _
        Public Property numCUPS() As String
            Get
                Return Me.numCUPSField
            End Get
            Set
                Me.numCUPSField = value
                Me.RaisePropertyChanged("numCUPS")
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=15)>  _
        Public Property sexoColaborador() As String
            Get
                Return Me.sexoColaboradorField
            End Get
            Set
                Me.sexoColaboradorField = value
                Me.RaisePropertyChanged("sexoColaborador")
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(WrapperName:="obtenerTodos", WrapperNamespace:="http://ws.servicesweb.rrhhintegration.com/", IsWrapped:=true)>  _
    Partial Public Class obtenerTodos
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="", Order:=0)>  _
        Public nombre As String
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="", Order:=1)>  _
        Public codigoTrabajador As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal nombre As String, ByVal codigoTrabajador As String)
            MyBase.New
            Me.nombre = nombre
            Me.codigoTrabajador = codigoTrabajador
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(WrapperName:="obtenerTodosResponse", WrapperNamespace:="http://ws.servicesweb.rrhhintegration.com/", IsWrapped:=true)>  _
    Partial Public Class obtenerTodosResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="", Order:=0),  _
         System.Xml.Serialization.XmlArrayAttribute(),  _
         System.Xml.Serialization.XmlArrayItemAttribute("item", Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public response() As ServicioWeb1.trabajador
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal response() As ServicioWeb1.trabajador)
            MyBase.New
            Me.response = response
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface TrabajadorWSChannel
        Inherits ServicioWeb1.TrabajadorWS, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class TrabajadorWSClient
        Inherits System.ServiceModel.ClientBase(Of ServicioWeb1.TrabajadorWS)
        Implements ServicioWeb1.TrabajadorWS
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        Public Function registrarTrabajador(ByVal trabajador As ServicioWeb1.trabajador) As String Implements ServicioWeb1.TrabajadorWS.registrarTrabajador
            Return MyBase.Channel.registrarTrabajador(trabajador)
        End Function
        
        Public Function obtenerUno(ByVal codigoTrabajador As String) As ServicioWeb1.trabajador Implements ServicioWeb1.TrabajadorWS.obtenerUno
            Return MyBase.Channel.obtenerUno(codigoTrabajador)
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function ServicioWeb1_TrabajadorWS_obtenerTodos(ByVal request As ServicioWeb1.obtenerTodos) As ServicioWeb1.obtenerTodosResponse Implements ServicioWeb1.TrabajadorWS.obtenerTodos
            Return MyBase.Channel.obtenerTodos(request)
        End Function
        
        Public Function obtenerTodos(ByVal nombre As String, ByVal codigoTrabajador As String) As ServicioWeb1.trabajador()
            Dim inValue As ServicioWeb1.obtenerTodos = New ServicioWeb1.obtenerTodos()
            inValue.nombre = nombre
            inValue.codigoTrabajador = codigoTrabajador
            Dim retVal As ServicioWeb1.obtenerTodosResponse = CType(Me,ServicioWeb1.TrabajadorWS).obtenerTodos(inValue)
            Return retVal.response
        End Function
        
        Public Function eliminarTrabajador(ByVal codigoTrabajador As String) As String Implements ServicioWeb1.TrabajadorWS.eliminarTrabajador
            Return MyBase.Channel.eliminarTrabajador(codigoTrabajador)
        End Function
        
        Public Function actualizarTrabajador(ByVal trabajador As ServicioWeb1.trabajador) As String Implements ServicioWeb1.TrabajadorWS.actualizarTrabajador
            Return MyBase.Channel.actualizarTrabajador(trabajador)
        End Function
    End Class
End Namespace
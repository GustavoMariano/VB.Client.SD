﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace SOAPSERVICES
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute([Namespace]:="http://localhost:8888/", ConfigurationName:="SOAPSERVICES.AbcBolinhasPortType")>  _
    Public Interface AbcBolinhasPortType
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://localhost:8888/verifica_NumeroPar", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function verifica_NumeroPar(ByVal in0 As Integer) As <System.ServiceModel.MessageParameterAttribute(Name:="out2")> Boolean
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://localhost:8888/verifica_NumeroPar", ReplyAction:="*")>  _
        Function verifica_NumeroParAsync(ByVal in0 As Integer) As <System.ServiceModel.MessageParameterAttribute(Name:="out2")> System.Threading.Tasks.Task(Of Boolean)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://localhost:8888/valida_CPF", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function valida_CPF(ByVal cpf As String) As <System.ServiceModel.MessageParameterAttribute(Name:="out0")> Boolean
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://localhost:8888/valida_CPF", ReplyAction:="*")>  _
        Function valida_CPFAsync(ByVal cpf As String) As <System.ServiceModel.MessageParameterAttribute(Name:="out0")> System.Threading.Tasks.Task(Of Boolean)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://localhost:8888/math_operation", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function math_operation(ByVal operador As String, ByVal num1 As Integer, ByVal num2 As Integer) As <System.ServiceModel.MessageParameterAttribute(Name:="out1")> String
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://localhost:8888/math_operation", ReplyAction:="*")>  _
        Function math_operationAsync(ByVal operador As String, ByVal num1 As Integer, ByVal num2 As Integer) As <System.ServiceModel.MessageParameterAttribute(Name:="out1")> System.Threading.Tasks.Task(Of String)
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface AbcBolinhasPortTypeChannel
        Inherits SOAPSERVICES.AbcBolinhasPortType, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class AbcBolinhasPortTypeClient
        Inherits System.ServiceModel.ClientBase(Of SOAPSERVICES.AbcBolinhasPortType)
        Implements SOAPSERVICES.AbcBolinhasPortType
        
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
        
        Public Function verifica_NumeroPar(ByVal in0 As Integer) As Boolean Implements SOAPSERVICES.AbcBolinhasPortType.verifica_NumeroPar
            Return MyBase.Channel.verifica_NumeroPar(in0)
        End Function
        
        Public Function verifica_NumeroParAsync(ByVal in0 As Integer) As System.Threading.Tasks.Task(Of Boolean) Implements SOAPSERVICES.AbcBolinhasPortType.verifica_NumeroParAsync
            Return MyBase.Channel.verifica_NumeroParAsync(in0)
        End Function
        
        Public Function valida_CPF(ByVal cpf As String) As Boolean Implements SOAPSERVICES.AbcBolinhasPortType.valida_CPF
            Return MyBase.Channel.valida_CPF(cpf)
        End Function
        
        Public Function valida_CPFAsync(ByVal cpf As String) As System.Threading.Tasks.Task(Of Boolean) Implements SOAPSERVICES.AbcBolinhasPortType.valida_CPFAsync
            Return MyBase.Channel.valida_CPFAsync(cpf)
        End Function
        
        Public Function math_operation(ByVal operador As String, ByVal num1 As Integer, ByVal num2 As Integer) As String Implements SOAPSERVICES.AbcBolinhasPortType.math_operation
            Return MyBase.Channel.math_operation(operador, num1, num2)
        End Function
        
        Public Function math_operationAsync(ByVal operador As String, ByVal num1 As Integer, ByVal num2 As Integer) As System.Threading.Tasks.Task(Of String) Implements SOAPSERVICES.AbcBolinhasPortType.math_operationAsync
            Return MyBase.Channel.math_operationAsync(operador, num1, num2)
        End Function
    End Class
End Namespace

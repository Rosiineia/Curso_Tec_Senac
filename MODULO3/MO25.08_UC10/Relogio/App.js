
import React, { Component} from 'react';
import {
  SafeAreaView,
  ScrollView,
  StatusBar,
  StyleSheet,
  Text,
 TouchableOpacity,
  View,
} from 'react-native';

export default class App extends Component{
  constructor(props){
    super(props)
    this.state={
      data: new Date(),
      textostatus:'Desativado'
      //contagem: 0 - prox atividade
    }
    this.liga = this.liga.bind(this)
    this.idTimer = null
  }

  liga() {                                    ///id - setInterval(metodo a ser executado(), intervalo de tempo em milisegundos) 
                                                //clearInterval(id) 
    if(this.idTimer != null){
      clearInterval(this.idTimer)
      this.idTimer = null
      this.setState({textostatus:'Desativado'})// this.textoBotão.ligar
    }else{
      this.setState({textostatus:'Ativado', })// this.textoBotão.pausar
    this.idTimer= setInterval(()=>{this.setState({data : new Date()})} , 1000)//contagem(this.contahem+ 1)
    }    
  }
  render(){
    return(
      <View style={{ alignItems:'center' }}>        
        <Text style={{color:'red',fontSize:25,fontWeight:'bold',
    textAlign:'center', padding:40 }}> Relógio </Text>
    <Text style={{color:'blue',fontSize:35,fontWeight:'bold',
    textAlign:'center', padding:10 }}>{this.state.data.toLocaleTimeString()}s</Text>
    <Text style={{color:'gray',fontSize:15,fontWeight:'bold',
    textAlign:'center', padding:10 }}> {this.state.textostatus} </Text>
    <View style={{flexDirection:'row'}}>
      <TouchableOpacity onPress={this.liga} style={estilo.botaoLigar}>
      <Text style={estilo.textoLigar}>Ligar</Text>
      </TouchableOpacity>
    </View>
      </View>
    )
  }
}
const estilo = StyleSheet.create({
  botaoLigar:{
    color:'white',    
   
    alignItems:'center', 
    padding:10,
    backgroundColor:'green',
    flex:1,
    borderRadius:15,
    height:45    
  },
  textoLigar:{
    fontSize:20,
    fontWeight:'bold',
    color:'white'

  }

})




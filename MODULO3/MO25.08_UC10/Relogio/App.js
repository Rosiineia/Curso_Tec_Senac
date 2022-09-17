
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
    }
    this.liga = this.liga.bind(this)
  }

  liga() {
    this.setState({textostatus:'Ativado'})
  }
  render(){
    return(
      <View style={{ alignItems:'center' }}>        
        <Text style={{color:'red',fontSize:25,fontWeight:'bold',
    textAlign:'center', padding:40 }}> Relógio </Text>
    <Text style={{color:'blue',fontSize:35,fontWeight:'bold',
    textAlign:'center', padding:10 }}>{this.state.data.toLocaleTimeString()}</Text>
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




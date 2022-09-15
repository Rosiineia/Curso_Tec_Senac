import React, { Component } from 'react';
import {//Importa bibliotecas de Componentes
  SafeAreaView,
  ScrollView,
  StatusBar,
  StyleSheet,
  Text,
  Image,
  View,
} from 'react-native';

export default class  Menu extends Component {
  render(){
    return(
      <View style={estilo.menu}>
        <Image 
        style={estilo.imagem}
        source={require('./imgReact.png')} />
      <Text style={estilo.texto1}> Home - Produtos - Sobre </Text>  
      
      </View>
    )
  }
}
const estilo = StyleSheet.create({
  menu:{
    flexDirection: 'row',
    alignItems:'center',
    justifyContent:'center',
    margin:10,
    backgroundColor:'lightblue'    
  },
  imagem:{
    height:55,
    width:55
  },
  texto1:{
    fontSize:15,
    color: 'red',
    fontWeight:'bold',
    margin:20
  }
})
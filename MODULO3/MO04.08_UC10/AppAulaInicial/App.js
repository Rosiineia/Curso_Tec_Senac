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
import Menu from './src/menu';
import Produtos from './src/produtos';

export default class App extends Component {
  render(){
    return(
      <View>
        <Menu/>
        <Produtos
        descricao="Groot"
        preco ={ 250}/>
        
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
  },
  texto2:{
    fontSize:15,
    color: 'black',
    fontWeight:'bold',
    margin:1,
    textAlign:'left'
    
  }
})
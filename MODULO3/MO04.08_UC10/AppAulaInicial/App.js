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
      
      <ScrollView>
      <Menu/>
      <View>       
        <Produtos
        nomeImagem= {require('./src/Img_Groot.jpeg')}
        descricao="Groot"
        preco ={ 225}/>
        <Produtos
        nomeImagem= {require('./src/Img_ioda.jpg')}
        descricao="Yoda"
        preco ={ 175}/>                 
      </View>
      </ScrollView>
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
    height:30,
    width:30
  },
  texto1:{
    fontSize:15,
    color: 'red',
    fontWeight:'bold',
    margin:20
  },
})
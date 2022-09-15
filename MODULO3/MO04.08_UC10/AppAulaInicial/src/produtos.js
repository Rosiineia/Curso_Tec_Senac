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


export default class Produtos extends Component {
  render(){
    return(
      <View> 
        <View style={{justifyContent:'center', alignItems:'center'}}>
          <Image source={require('./Img_ioda.jpg')}
          style={{height:250,width:250, margin: 15}}> 
          </Image>
          <Text style={estilo.texto2}> Descrição: {this.props.descricao} </Text>
          <Text style={estilo.texto2}> Preço: {this.props.preco}  </Text>
          <Text style={estilo.texto2}> Reservas: </Text>
          <Text style={estilo.texto2}> Total:</Text>
                
          </View>
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
  texto2:{
    fontSize:15,
    color: 'blue',
    fontWeight:'bold',
    margin:1,
    textAlign:'left'
    
  }
})
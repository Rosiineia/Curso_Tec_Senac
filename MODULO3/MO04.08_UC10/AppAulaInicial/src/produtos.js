import React, { Component } from 'react';
import {//Importa bibliotecas de Componentes que vou usar
  SafeAreaView,
  ScrollView,
  StatusBar,
  StyleSheet,
  Text,
  Image,
  View,
  TouchableOpacity
} from 'react-native';

export default class Produtos extends Component {
  constructor(props){
    super(props)
    this.state={
      reservas:0,
      total:0,
      corTextoReserva:'black',
      textoBotaoLimpar:''

    }
  }
  reservar(){
    this.setState({      //Atualiza os states e chama o render()
      reservas:this.state.reservas + 1,
      total:this.state.total + this.props.preco,
      textoBotaoLimpar :'Limpar',
      corTextoReserva:'red'
    })  
  }
  limpar(){
    this.setState({       //Atualiza os states e chama o render()
     reservas:0,
     total:0,
     corTextoReserva:'black',
     textoBotaoLimpar:''

    })
  }
  render(){
    return(
      <View> 
        <View style={estiloProdutos.menu}>
          <View>
            <Image 
            source={this.props.nomeImagem}
            style={{height:200,width:200, margin: 10}}> 
          </Image>
        </View>
        <View>
          <Text style={estiloProdutos.textoProdutos}> Descrição: {this.props.descricao}</Text>
          <Text style={estiloProdutos.textoProdutos}> Preço: {this.props.preco} </Text>
          <Text style={{
            color:this.state.corTextoReserva, 
            fontSize:14,            
            fontWeight:'bold',
            textAlign:'left'}}> Reservas:{this.state.reservas} </Text>
          <Text style={estiloProdutos.textoProdutos}> Total: {this.state.total}</Text>
          <View style={{flexDirection:'row'}}>
            <TouchableOpacity onPress={()=> this.reservar() }>
          <Text style={estiloProdutos.botãoProdutos}>Reservar</Text>
          </TouchableOpacity>
          <TouchableOpacity onPress={()=> this.limpar() }>
          <Text style={estiloProdutos.botãoProdutos}>{this.state.textoBotaoLimpar}</Text>
          </TouchableOpacity>
          </View>          
        </View>        
      </View>
     </View>
    )
  }
}
const estiloProdutos = StyleSheet.create({
  menu:{    
    alignItems:'center',
    justifyContent:'center',
    margin:10,
    backgroundColor:'lightgrey',
    borderRadius:60  
  },
  imagem:{
    height:60,
    width:60
  },
  textoProdutos:{
    fontSize:14,
    color: 'black',
    fontWeight:'bold',
    textAlign:'left'    
  },
  botãoProdutos:{
    fontSize:13,
    color: 'black',
    backgroundColor:'green',
    margin:10,
    textAlign:'center',
    fontWeight:'bold',
    borderRadius:5


  }
})
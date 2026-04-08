import React,{Component} from 'react'

class ClassWithStates extends Component{
    constructor(props){
        super(props);
        this.state={
            data:null
        };
    }


componentDidMount(){
    console.log("ComponentDidMount",":load data from an external source etc,now");
    this.fetchData();
}

componentDidUpdate(prevProps,prevState){
    if(prevState.data!==this.state.data){
        console.log('Data has been updated:',this.state.data);
    }
}
componentWillUnmount(){
    console.log('Component will unmount');
}

fetchData(){
    setTimeout(()=>{
        this.setState({data:'Some data fetched from API'});
    },1000);
    console.log("data fetched");
}

render(){
    return(
        <div>
            <p>data: {this.state.data}</p>
        </div>
    );
}
}

export default ClassWithStates

import React,{Component} from "react";

export default class parentComp extends Component
{
    constructor(props){
        super(props);
        this.state={
            parentName:"i am the parent"
        };
    }
    greetParent(){
        console.log("Function called indicating child has finished processing");
        alert("Hello world")
    }
    render(){
        return(
            <div>
                <p>Here We display rows of data from a table</p>
                <ChildComponent greetHandler={this.greetParent}/>
            </div>
        )
    }
}


class ChildComponent extends Component{
    render(){
        return(
            <div>
                <p>Child component allows edit of a record selected
                     from the parent component</p>
                <p>Once data is updated in database,inform parent</p>
                <button onClick={this.props.greetHandler}>Click me</button>
            </div>
        )
    }
}
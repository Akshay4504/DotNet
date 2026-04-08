import React,{Component} from "react";
//import propTypes from 'prop-types'

class StateAndProps extends React.Component{
    constructor(props){
        super(props);
        this.state={name:"State and prop",}
    }
    render(){
        return(
            <section>
                <p>Welcome to programming in {this.props.lang}</p>
                <JTP jtpProp={this.state.name} langProp={this.props.lang}/>
            </section>
        );
    }
}

StateAndProps.defaultProps=
{lang : 'reactJs'}

class JTP extends React.Component{
    render(){
        return(
            <div>
                <h1>State & Props Example</h1>
                <h3>Welcome to {this.props.jtpProp}</h3>
                <p>Property from Parent: {this.props.langProp} </p>
                <p>It is impossible to combine both state and props in your app.
                    You can set the state in the parent component and pass it to a child component
                    using props.
                </p>
            </div>
        );
    }
}
export default StateAndProps;
import React,{Component} from 'react';
class Displaybio extends Component{
    constructor(){
        super();
        console.log('Component this',this);
        this.state={displayBio:true};
        this.toggleDisplayBio=this.toggleDisplayBio.bind(this);
    }
    toggleDisplayBio(){
        this.setState({displayBio:!this.state.displayBio});
    }
    render(){
        const bio=this.state.displayBio?(
            <div>
                <p><h3>creating astateful component using ES6 syntax..</h3></p>
            </div>
        ): null;
        return(
            <div><h1>State rendered</h1>
            {bio}
            <button onClick={this.toggleDisplayBio}>Toggle bio</button>
            </div>
        );
    }
}
export default Displaybio;
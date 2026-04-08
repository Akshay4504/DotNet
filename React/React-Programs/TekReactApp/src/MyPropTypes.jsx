import react,{Component} from 'react';
import PropTypes from 'prop-types';

class MyPropTypes extends React.Component{
    render(){
        return(
            <div>
                <h1>Reavtjs Props validation example</h1>
                <table>
                    <thead>
                        <tr>
                            <th>Type</th><th>value</th><th>valid:</th>
                        </tr>
                    </thead>
                    <tbody>
                    <tr>
                        <td>Array</td>
                        <td>{this.props.propArray}</td>
                        <td>{this.props.propArray ? "true" : "false"}</td>
                    </tr>
                    <tr>
                         <td>Boolean</td>
                        <td>{this.props.propBool ? "true" : "false"}</td>
                        <td>{this.props.propBool ? "true" : "false"}</td>
                    </tr>
                    <tr>
                         <td>Function</td>
                        <td>{this.props.propFunc(5)}</td>
                        <td>{this.props.propFunc(5) ? "true" : "false"}</td>
                    </tr>
                    <tr>
                         <td>String</td>
                        <td>{this.props.propString}</td>
                        <td>{this.props.propString ? "true" : "false"}</td>
                    </tr>
                    <tr>
                         <td>Number</td>
                        <td>{this.props.propNumber}</td>
                        <td>{this.props.propNumber ? "true" : "false"}</td>
                    </tr>
                    </tbody>
                </table>
            </div>
        );
    }
}


MyPropTypes.propTypes={
    propArray:PropTypes.array.isRequired,
    propBool:PropTypes.bool.isRequired,
    propFunc:PropTypes.Func,
    propNumber:PropTypes.number,
    propNumber:PropTypes.string,
}

MyPropTypes.defaultProps={
    propArray:[1,2,3,4,5],
    propBool:true,
    propFunc:function(x){return x+5},
    propNumber:1,
    propString:"my react Props",
}

export default MyPropTypes
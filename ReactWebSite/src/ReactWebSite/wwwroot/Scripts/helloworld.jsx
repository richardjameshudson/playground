
var HelloWorld = React.createClass({
    render: function () {
        return (
          <div>Hello {this.props.name}<div>{this.props.something} </div></div>
        );
    }
});

ReactDOM.render(
    <HelloWorld name="Richard" something="this is somemore content"/>,
    document.getElementById('content')
);
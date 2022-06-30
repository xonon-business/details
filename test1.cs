using ourframework;
using ourframework.hooks;


namespace App
{
    [Route("/")]
    class App : ourframework.component
    {
        [addState]
        int count; void setCount
        render()
        {
            return @$"
                <div>
                    <p>Count {this.count}</p>
                    <button on:click={this.clicked()}>click to increase</button>
                </div>
            "    
        }

        clicked()
        {
            this.setCount(this.count + 1);
        }
    }
}
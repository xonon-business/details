# Proposal 002

Proposal 002 is a c# and javascript framwork for building user interfaces.
name ideaes:
 - Radium 
 - FlexUI

# Possible syntax

## Javascript

```tsx
// main.ts
import App from './App'
import Radium, { render, createContainer } from 'radium'


render(<App />, createContainer('#app'))
```

```tsx
// App.ts
// import radium for jsx
import Radium, { addState, Page } from 'radium'
import { Body, Text, Button, Widget, WidgetProps } from 'radium/widgets'


class CustomButton extends Widget {
    text: string;

    constructor(props: WidgetProps, newProps: { text: string }) {
        super(props)
        this.text = newProps.text
    }

    render() {
        return <Button style={{
            backgroud: 'black',
            color: 'white'
        }}>{this.text}</Button>
    }
}


export default class App extends Page {

    @addState(0) count: number; setCount: Function;

    onConnected() {
        console.log("component connected")
    }

    render() {
        return (
            <Body>
                <Text>Count {this.count}</Text>
                <CustomButton on:click={() => this.setCount(this.count + 1)} text="Click to increase" />
            </Body>
        )
    }

}
```


## CSharp

```csharp
// main.cs
using ourframework;
using App;

class Main {
    static void Main(args string[]) {
        ourframework.render(new App, ourframework.createDomContainer("#app"))
    } 
}
```
```csharp
// App.cs
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
```


Staus: to be reviewed by dway.
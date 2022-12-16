import { LightningElement } from 'lwc';

export default class App extends LightningElement {

    async handleChangeTable(event){
        let canvas = this.template.querySelector('my-canvas');
        canvas.handleSetTable(event.detail);
    }
}

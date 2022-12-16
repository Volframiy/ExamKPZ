import { LightningElement } from 'lwc';

export default class Toolbar extends LightningElement {

    handleChangeTable(event){
        this.dispatchEvent(new CustomEvent('changetable', {detail: event.target.name}));
    }

    get rowClass(){ return 'slds-col slds-size_1-of-1 slds-p-top_medium containerrow';}
    get buttonClass(){ return 'slds-button slds-button_brand barbutton';}
}
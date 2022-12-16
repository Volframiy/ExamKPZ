import { LightningElement, track, api } from 'lwc';

export default class Canvas extends LightningElement {
    table = 'home';

    @api
    handleSetTable(table){
        this.table = table;
    }

    async handleRefresh(){
        if(this.isStudent) await this.template.querySelector('my-student').handleRefresh();
        if(this.isMark) await this.template.querySelector('my-mark').handleRefresh();
        if(this.isWork) await this.template.querySelector('my-work').handleRefresh();

        alert('Success Refreshing');
    }

    async handleDelete(){
        if(this.isStudent) await this.template.querySelector('my-student').handleDelete();

        alert('Success Deleting');
    }

    async handleSave(){
        if(this.isStudent) await this.template.querySelector('my-student').handleSave();

        alert('Success Saving');
    }

    async handleAddRow(){
        if(this.isStudent) await this.template.querySelector('my-student').handleAddRow();
        if(this.isMark) await this.template.querySelector('my-mark').handleAddRow();
        if(this.isWork) await this.template.querySelector('my-work').handleAddRow();
    }

    get isStudent(){ return this.table === 'student' ? true : false;}
    get isMark(){ return this.table === 'mark' ? true : false;}
    get isWork(){ return this.table === 'work' ? true : false;}
    get isHome(){ return this.table === 'home' ? true : false;}
    get buttonClass(){ return 'slds-button slds-button_outline-brand';}
    get containerButtonClass(){ return 'slds-col slds-size_1-of-4 slds-align_absolute-center';}
}
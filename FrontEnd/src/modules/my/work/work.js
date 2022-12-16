import { LightningElement, track, api } from 'lwc';
import axios from 'axios';

export default class Door extends LightningElement {
    @track data = []

    idsForDelete = [];
    rowsForUpdate = [];
    rowsForInsert = [];

    async connectedCallback(){
        let res = await axios.get('https://localhost:7244/api/LaboratoryWorks');

        res.data.forEach(d => {
            this.data.push({...d});
        });
    }

    @api 
    async handleRefresh(){
        let res = await axios.get('https://localhost:7244/api/LaboratoryWorks')
        this.data = [];

        res.data.forEach(d => {
            this.data.push({...d});
        });
    }

    @api 
    handleDelete(){
        
    }

    @api 
    async handleSave(){
        this.rowsForInsert = [];
        this.rowsForUpdate = [];
        this.idsForDelete = [];
        this.handleRefresh();
    }

    @api 
    handleAddRow(){
        
    }

    handleChangeRow(event){

    }
}
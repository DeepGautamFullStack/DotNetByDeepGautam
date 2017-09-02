import { Component, OnInit } from '@angular/core';
import { ConsumeRestAPIService } from '../service/consume-rest-api.service'
import { ReactiveFormsModule, FormGroup, FormControl, FormsModule, FormArray, FormBuilder, Validators } from '@angular/forms';

@Component({
    selector: 'my-appcrudoperation',
    templateUrl: './app.crud.component.html',
})
export class AppCrudOperationComponent implements OnInit {
    values: any;
    clients: Client;
    public messageInsert: string = "";
    public messageUpdate: string;
    public messageDelete: string;
    public globalResponse: any;
    public clientInsertForm: FormGroup;
    public clientUpdateForm: FormGroup;
    public clientDeleteForm: FormGroup;

    
    constructor(private consumeRestAPIService: ConsumeRestAPIService)
    {
        this.messageInsert = "";
    }
    insertClient() {
        var name = this.clientInsertForm.controls['nameInsert'].value;
        var code = this.clientInsertForm.controls['codeInsert'].value;

        let clientModel = new Client(1000, name, code);
        this.consumeRestAPIService.postClient(clientModel)
            .subscribe((result) => {
                this.globalResponse = result;                 
            },
            error => { //This is error part
                console.log(error);
                this.messageInsert = error;
            },
            () => {
                // 'onCompleted' callback. This is Success part
                if (this.globalResponse.Name == name) {
                    this.messageInsert = "Client Inserted successfuly";
                    this.consumeRestAPIService.getAllClients()
                        .subscribe((result) => {
                            this.clients = result;
                        })
                }
            }
            )
    }
    updateClient() {
        var id = this.clientUpdateForm.controls['id'].value;
        var name = this.clientUpdateForm.controls['name'].value;
        var code = this.clientUpdateForm.controls['code'].value;
        let clientModelUpdate = new Client(id, name, code);
        this.consumeRestAPIService.putClient(clientModelUpdate.Id, clientModelUpdate)
            .subscribe((result) => {
                this.globalResponse = result;
                },
                error => { //This is error part
                    console.log(error);
                    this.messageUpdate = error;
                },
                () => {
                    // 'onCompleted' callback. This is Success part
                    if (this.globalResponse.Id == id) {
                        this.messageUpdate = "Client Updated successfuly";
                        this.consumeRestAPIService.getAllClients()
                            .subscribe((result) => {
                                this.clients = result;
                            })
                    }
                }
            )
    }
    deleteClient() {
        var id = this.clientDeleteForm.controls['id'].value;
        this.consumeRestAPIService.deleteClient(id)
            .subscribe((result) => {
                this.globalResponse = result;
            },
            error => { //This is error part
                console.log(error);
                this.messageDelete = error;
            },
            () => {
                // 'onCompleted' callback. This is Success part
                if (this.globalResponse.Id == id) {
                    this.messageDelete = "Client Deleted successfuly";
                    this.consumeRestAPIService.getAllClients()
                        .subscribe((result) => {
                            this.clients = result;
                        })
                }
            }
            )
    }

    ngOnInit() {
        this.messageInsert = "";
        this.clientInsertForm = new FormGroup({
            nameInsert: new FormControl(),
            codeInsert: new FormControl()
        });
        this.clientUpdateForm = new FormGroup({
            id: new FormControl(),
            name: new FormControl(),
            code: new FormControl(),
        });

        this.clientDeleteForm = new FormGroup({
            id: new FormControl()
        });


        this.consumeRestAPIService.getAllClients()
            .subscribe((result) => {
                this.clients = result;
            })
    }

}
class Client {
    public Id: number;
    public Name: string;
    public Code: string;
    constructor(Id: number, Name: string, Code: string) {
        this.Id = Id;
        this.Name = Name;
        this.Code = Code;

    }
}

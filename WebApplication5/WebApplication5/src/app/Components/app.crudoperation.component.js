"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var consume_rest_api_service_1 = require("../service/consume-rest-api.service");
var forms_1 = require("@angular/forms");
var AppCrudOperationComponent = (function () {
    function AppCrudOperationComponent(consumeRestAPIService) {
        this.consumeRestAPIService = consumeRestAPIService;
        this.messageInsert = "";
        this.messageInsert = "";
    }
    AppCrudOperationComponent.prototype.insertClient = function () {
        var _this = this;
        var name = this.clientInsertForm.controls['nameInsert'].value;
        var code = this.clientInsertForm.controls['codeInsert'].value;
        var clientModel = new Client(1000, name, code);
        this.consumeRestAPIService.postClient(clientModel)
            .subscribe(function (result) {
            _this.globalResponse = result;
        }, function (error) {
            console.log(error);
            _this.messageInsert = error;
        }, function () {
            // 'onCompleted' callback. This is Success part
            if (_this.globalResponse.Name == name) {
                _this.messageInsert = "Client Inserted successfuly";
                _this.consumeRestAPIService.getAllClients()
                    .subscribe(function (result) {
                    _this.clients = result;
                });
            }
        });
    };
    AppCrudOperationComponent.prototype.updateClient = function () {
        var _this = this;
        var id = this.clientUpdateForm.controls['id'].value;
        var name = this.clientUpdateForm.controls['name'].value;
        var code = this.clientUpdateForm.controls['code'].value;
        var clientModelUpdate = new Client(id, name, code);
        this.consumeRestAPIService.putClient(clientModelUpdate.Id, clientModelUpdate)
            .subscribe(function (result) {
            _this.globalResponse = result;
        }, function (error) {
            console.log(error);
            _this.messageUpdate = error;
        }, function () {
            // 'onCompleted' callback. This is Success part
            if (_this.globalResponse.Id == id) {
                _this.messageUpdate = "Client Updated successfuly";
                _this.consumeRestAPIService.getAllClients()
                    .subscribe(function (result) {
                    _this.clients = result;
                });
            }
        });
    };
    AppCrudOperationComponent.prototype.deleteClient = function () {
        var _this = this;
        var id = this.clientDeleteForm.controls['id'].value;
        this.consumeRestAPIService.deleteClient(id)
            .subscribe(function (result) {
            _this.globalResponse = result;
        }, function (error) {
            console.log(error);
            _this.messageDelete = error;
        }, function () {
            // 'onCompleted' callback. This is Success part
            if (_this.globalResponse.Id == id) {
                _this.messageDelete = "Client Deleted successfuly";
                _this.consumeRestAPIService.getAllClients()
                    .subscribe(function (result) {
                    _this.clients = result;
                });
            }
        });
    };
    AppCrudOperationComponent.prototype.ngOnInit = function () {
        var _this = this;
        this.messageInsert = "";
        this.clientInsertForm = new forms_1.FormGroup({
            nameInsert: new forms_1.FormControl(),
            codeInsert: new forms_1.FormControl()
        });
        this.clientUpdateForm = new forms_1.FormGroup({
            id: new forms_1.FormControl(),
            name: new forms_1.FormControl(),
            code: new forms_1.FormControl(),
        });
        this.clientDeleteForm = new forms_1.FormGroup({
            id: new forms_1.FormControl()
        });
        this.consumeRestAPIService.getAllClients()
            .subscribe(function (result) {
            _this.clients = result;
        });
    };
    return AppCrudOperationComponent;
}());
AppCrudOperationComponent = __decorate([
    core_1.Component({
        selector: 'my-appcrudoperation',
        templateUrl: './app.crud.component.html',
    }),
    __metadata("design:paramtypes", [consume_rest_api_service_1.ConsumeRestAPIService])
], AppCrudOperationComponent);
exports.AppCrudOperationComponent = AppCrudOperationComponent;
var Client = (function () {
    function Client(Id, Name, Code) {
        this.Id = Id;
        this.Name = Name;
        this.Code = Code;
    }
    return Client;
}());
//# sourceMappingURL=app.crudoperation.component.js.map
import { Injectable } from '@angular/core';
import { Http,RequestOptions,Headers } from '@angular/http';
import 'rxjs/add/operator/map';

@Injectable()
export class ConsumeRestAPIService {

  constructor(private http:Http) {
    console.log("hello you are ready to consume restful service.")
   }
  //Below angular service is calling a webapi values controller.
  getValues()
    { 
      return this.http.get("http://localhost:49328/api/values")
      .map(res=>res.json());
  }
   //Below is the method to Get All Clients
    getAllClients() {

      return this.http.get("http://localhost:53251/api/Clients")
          .map(res => res.json());
    }
    //Below is the method to insert client
    postClient(model:any)
    {     
        return this.http.post("http://localhost:53251/api/Clients",model)
      .map(res=>res.json());
    }
    //Below is the method to update client
    putClient(id: any, model: any) {
        return this.http.put("http://localhost:53251/api/Clients?id=" + id, model)
            .map(res => res.json());
    }
    //Below is the method to delete client
    deleteClient(id: any) {
        return this.http.delete("http://localhost:53251/api/Clients?id=" + id)
            .map(res => res.json());
    }
   getPosts()
   {
      return this.http.get("https://jsonplaceholder.typicode.com/posts")
      .map(res=>res.json());
   }
    

}

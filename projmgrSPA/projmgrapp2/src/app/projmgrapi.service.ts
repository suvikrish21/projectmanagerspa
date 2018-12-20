import { Injectable } from '@angular/core';
import { Http} from '@angular/http';
import {map} from 'rxjs/operators';

import { Observable } from 'rxjs/internal/Observable';
import { BehaviorSubject  } from 'rxjs/internal/BehaviorSubject';
import { RequestOptionsArgs } from '@angular/http';
import { RequestOptions } from '@angular/http';
import { Headers } from '@angular/http';




@Injectable({
  providedIn: 'root'
})
export class ProjmgrapiService {

  constructor(private http : Http) { }

  delete(url : string, id : number) : Observable <any> {

    let hdrs = new Headers({'Content-Type' : 'application/json',
    'Access-Control-Allow-Origin' : '*'});
let options =  new RequestOptions({headers : hdrs});
//let body = JSON.stringify(model);

return this.http.delete(url + id,  
options).pipe(map(resp => <any> resp.json()));
  }
  
  put(url : string, id : number, model : any) : Observable <any> {

    let hdrs = new Headers({'Content-Type' : 'application/json',
    'Access-Control-Allow-Origin' : '*'});
let options =  new RequestOptions({headers : hdrs});
let body = JSON.stringify(model);

return this.http.put(url + id,  body,
options).pipe(map(resp => <any> resp.json()));
  }

  post(url : string, model : any) : Observable<any> {
    //const url = "http://localhost:54691/api/users";

    //const data = {data: {'first_name' : 'km', 'last_name' : '2', 'emp_id' : '1002' }};
   
    
    var headers = new Headers();

    headers.append('Content-Type', 'application/json');
   //let options =  new RequestOptions({headers : hdrs});

   let body = JSON.stringify(model);

   console.log(body);
   //console.log(options);
   console.log(headers);

    return this.http.post(url, body, {headers : headers}).
    pipe(map(resp => 
      resp.json()

    ));

  }

  get(url: string) : Observable<any> {

    //const url = "http://localhost:54691/api/users";
     

    return this.http.get(url).pipe(map(res =>
      {
        console.log(res.json());
        //const data = JSON.parse(res.text());
          
        return res.json();
      }))



  }
}

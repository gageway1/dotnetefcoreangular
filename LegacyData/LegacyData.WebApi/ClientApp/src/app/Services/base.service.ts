import { EventEmitter, Inject } from "@angular/core";
import { map, tap } from 'rxjs/operators';
import { HttpClient } from "@angular/common/http";

import { Observable, of } from 'rxjs';

export class BaseService {
    public static errorNotifier = new EventEmitter();

    constructor() { }

    protected logErrors<T>(preventEmit: boolean = null) {
        return tap((x:T) => x, error => {
            if (error.error instanceof ErrorEvent) {
                console.error("An error occurred:", error.error.message);
            } else {
                console.error("Backend returned code " + error.status + ", body was: ", error.error);
            }
            if (preventEmit !== false) {
                (<typeof BaseService>this.constructor).errorNotifier.emit(error);
            }
        });
    } 

    protected strCompare = (s1:string, s2:string) => s1 === s2 ? 0 : s1 > s2 ? 1 : -1;

    protected sort<T>(...fields: string[]){
        return map((result: Array<T>) => result.sort((l, r) => {
            for (let i = 0; i < fields.length; i++) {
                let comp = (typeof l[fields[i]]  === "string") ? this.strCompare(l[fields[i]], r[fields[i]]) : l[fields[i]]-r[fields[i]];
                if (comp !== 0) return comp;
            }
        }));
    }

      /**
     * Handle Http operation that failed.
     * Let the app continue.
     * @param operation - name of the operation that failed
     * @param result - optional value to return as the observable result
     */
    protected handleError<T>(operation = 'operation', result?: T) {
        return (error: any): Observable<T> => {

        // TODO: send the error to remote logging infrastructure
        console.error(error); // log to console instead

        // TODO: better job of transforming error for user consumption
        //this.log(`${operation} failed: ${error.message}`);

        // Let the app keep running by returning an empty result.
        return of(result as T);
    };
  }
}
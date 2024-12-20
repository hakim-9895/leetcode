/**
 * @param {integer} init
 * @return { increment: Function, decrement: Function, reset: Function }
 */
var createCounter = function(init) {

  let  current =init
    return{
         increment:function(){
          return  current+=1
        },
         reset:function(){
       return current =init

        },
        decrement:function(){
           return  current-=1
        }
        
    }
    
};

/**
 * const counter = createCounter(5)
 * counter.increment(); // 6
 * counter.reset(); // 5
 * counter.decrement(); // 4
 */
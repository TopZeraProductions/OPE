﻿var SystemJS = new function (log, jQuery) {
    
    this.init = () => {
        console.log(log);
        this.contentLoadHandler();
    };
    
    this.contentLoadHandler = () => {
        var els = document.getElementsByClassName("content-load");
        
        Array.from(els).forEach((el) => {
            this.chargeContent(el);
        });
    };

    this.chargeContent = (element) => {
        let url = jQuery(element).data("url");

        jQuery(element).LoadingOverlay("show");

        jQuery.get(
            url, 
            (data) => {
                let idBox = jQuery(element).attr('id');
                document.getElementById(idBox).innerHTML = data;
                jQuery(element).LoadingOverlay("hide");
            }
        );
    };
    
    this.assyncRegister = (url) => {
         jQuery.get(
            url,
            (data) => {
                if (data.message !== undefined){
                    jQuery.toast({
                        heading: 'Informativo:',
                        text: data.message,
                        icon: 'info',
                        loader: true,
                        loaderBg: '#9EC600',
                        position: 'top-right',
                    });
                }
            }
        );
    }
    
}("system.js was loaded !!", jQuery);

SystemJS.init();
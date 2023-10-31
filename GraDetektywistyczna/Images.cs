using System;
using System.Threading;
using static System.Console;

namespace GraDetektywistyczna
{
    class Images
    {
        public static string[] locks = { @"
ffLLCCCLftLGGGGGGGGCt,           ,i;;:,,,,.                   :;;i;,,,,,.              . ......,.;fi
CCLCG00GLff0G088800Gf,..         ,iii;,,,,,                   iiii;,,,,,.             ,;,,.,,:,:.1f1
GLiLCG00LLf00088880GL:..         .iii;,,,,,                   ;iii;,,,,,.             ....,,.,...tf;
f;:1fCG0GLL088888880G1..          ;ii;:,,,,.                  ;;ii;:::,,.               .,,.,,,,;ft;
C1:;tLCGGCtC888888800L...         :iii:,,,,.                 .;;;i;:,,,,                ....... ;fi;
GL,;1fLCGGLL888888880C, .         ,iii:,,,,.                 .iiii;:,,,.                        ttii
C0::itLC00GL088888880Gi .         :1ii:::,,.                 .iii;;:::,.                       .ffi;
C@1,;1LGG0GfC808888800f.          ittt;,,,,.              ....i;;;::::,.                       :L1;;
tCf;;ifCG0GCCG0G000GGGC;.         ;tft11iii;::,,,,....    ,;111111;::::..                      ,:;i;
fCCCL1fCGCGGGGG00000GGG1,.        :tfLCLLLLfLLfffftifftt11111t;;i111i1::fi,                    .,;i;
G8800L1GGCCCLffG0G0GGC1.,,.,,;i;;:;tfG0GL1fLLLLfffffffffffffft111it1;;,tf:f,                  .,;;i;
G@@880iLGGCCCf;tG0800GL:,:;:,i1t11111LLL1iLLLLLLLLLLLffftttttt,,ii;,,,i;tCG1                   ,;i1;
G@@@01:tLLLCGGGGff0000Gi.:;:,:;i1111tfLCtiffffffffftt11t1111t;,::::,,.:1fCLt;.                 ,iii;
G@8@f,;1fCLfLCGC1;L00GGt,,:,,,.....,:itt1:i111t11111111111;tC:i,,::::,.:,::1t.                 :i;;;
G@8@C:;itLGCLLfCftttttt1:.. ..     .:;iiii;;ii11111;iiii;ifGf1i11;,::,,    :ft.               .;i;;:
G@888;:;1fLCLffGGGCLfffti          .:;i;:::,,,,::;;;;iiitLf1ft::1Lf:,,.     1f;.              ,ii;i;
G@@@@f,:itffffLG000GGGGCf.          ,;;:,,,,            t1  ;;,:,:t;,:.    ,i.,,              :ii;;:
fGGGGC;:;1ttttLC0000CCGGG;          ,;;:,,,,.          .t;  .,;i;:;;i;,    ::.;,              i11i;:
LGCCCGCCi;ft1tfL0000GffLCi .        ,;;:,,,,.          ,f:   :ii;;i;::,    ,:1:              ,i1i;;:
G8888808L:tf1tttC80080GGGt..        ,ii;,,,,.          :f:   ;11;iii:;;     ;i.              :iii;;,
G@@@@@@@G;1fttt1t088880GGf...       ,ii;,,,,.          :t:   ;1i;1;:,,;.  .;i;.             .;iii;:,
G@8@@@@8t:i1fttt1C88880GGL:         .ii;,,,,.          ;f,   ;ii;t;.;i:.  ::.:,             ,iiii;:,
G@888880;:;111tt1L00000CG01         .;i;,,,,.         ,tf,.. :i;it:.;:,   :::;.             :iiii:,,
G@8888881,:i1ttt1t80080CfCt          ;i;:,,,.        .C80CLLffttCL;,;::.   ii.             .iiiii:,,
C888888@L,:;1ttt1iG80880CCf.         :i;:,,,.        ,G0088800GGGGL,,.:,  ,i,              ,iiii;,,,
L0GGGGG0G;,:it1111C80000GGC, .       :i;:,,,.        :0088888GLLff1.,::, ,:::.             ;1iii:,,,
G@8000GGGCCi;ftt1tC88880GGC; ..      ,i;:,,,.        i80888880LLLfi..i,  :.,;.            .i11i;:,,,
G@@@@@88880GifCt1tL080GG0Ct;...      ,;;:,,,.        :fLG000GGCCLL:.,;:. ;i;,             ,1i1i;:,,,
G@@@@@@@@@@0;1Cftt10@00GCLLt.....    ,;;:,,,.           .,:;ittt1i,.:,,:.;,,              ;ii1i:::,,
G@888888888f,;tfttif0G80GLCL,....... .;;:,,,.        ..     .ii:,...::;:,:;.        .... .iiii;:::,.
G@888888000L,:it1t11888880GG; ...... .:;;,,,.   .        .. ,1i;:,,,.,1:.:;   ...........:1iii;:::, 
L00000000000f,:tftti0@@880001...     .:;;,,,,   .           ,1i;,,,, .i::: .   ..........;1i1i::,:,.
C800GGGGGGGCLti1CLfiL@@880GGf..       :;;,,,,.              ,ii;,,,,,i,:,  ..   ........,i11i;::,,..
G@@@@@888000C0GfCCf1t88@880GL,        ,;;,,,,.              ,i1i::,,,,:,    .      .....:ii1i;:::,..
C800088888880G1ifCt1iG00GGGCL,        ,;:,,,,               ,ii;,,,,        .          .;iiii::::...
", @"
CC:;tfCGCLfLGGGGGGGGLt..          .;;;;,,,,,.                  .i;;i:,,,,,.            . ......,.   
CC::1fCG0GLL888888800C:..         .;ii;,,,,,.                  ,iiii:,,,,,.           ,;,,.,,,,:.:, 
C0;:itLCGGLt088888800Gi .          ;ii;:,,,,                   ,iii;:,:,,,            ....,..,...,, 
C81:;1fLGGCfG88888888Gi..          :ii;:,,,,.                  :;;i;:,,,,.               ,,.,,,,,,. 
C@f,;1fCG0GCG888888880t..          :ii;:,,,,.                  ;iii;:,,,,.              ........... 
L0C::ifCG00LL008888800L,          .11ii:,,,,.                 .;1ii;::,,,.                          
tLfti;tCGGGCCGGGG00GGGC: .        ,ttf1:,,,,                  .;ii;;::::,                           
C0GGGttCCLCGGGG00000GGGt,.        ,1fttt11ii::,...         ,:::1i;;::::,.                          .
G@880C1CGCCCLfL00G0GGCi,,.  ...   .1fLCLLLfffffttt1;i1ii;:,:it1iitt:::::,.                         .
G@@@80ifGGCCLt;L0000GCi.,::::i111iittG0GL1fLLLLfffftfffffffttttiii1t1ii:;fi.                      .:
G@@@Gi:1LLLGGCGCfG8000f.,::,,;i111111LLL1ifLLLLLLffLLLfffttttt1i111ti;::ft;f,                     ,;
G@88t,;ifCLfCGGL;10000C,.::,,,:;;i11tfLL1ifffffffffffttftttttt,,:;i:,,:;;fLC:                    .;:
G@88f:;itCGLLLLL11tLLff:,,..   ....,:1tti:1tttttttttt11111i1f::::::,,.,;1L0C1,                   ,i;
G@8@C::;1fCCLfCGCLftt11i,      .,. .:;iii;;;ii11i1i;iiiiiiiCf;i.,::::,.,;;iif;                   :i;
C@880;,;itfLffL0GGGGCCLL:          .:;i::::::;;ii1i;11iiifGCt1;t1:,::,,.  .,tt.                 ,;i;
fCCCGt::;1tttfC0000GGGGGi          .:;;:,,,.     ..,,::iLfitf;,:1Lt,,,.     iL1.                :i;:
L0GGGGCf:1t1ttLG000GfCCGt          .:;;:,,,,           ;t, ,;,,:,;t:.,.     i1;:.              .;;;:
G8888000iifttttL0000CLCCt.         .;;;,,,,.           i1.  .:;i::;;i;,    ,; .:               :iii:
G@@@@@881;tt1t1t00000000L,         .;i;:,,,.          .ti    ;ii;;;;:,,    :;:;,              .i1ii:
G@88@@@L:;1ttt11G88800GCf,..        ;i;,,,,.          ,t;   .;1i;ii;:i,    .:1,               ,i1ii:
G@88880;,;i11tt1L00000GGC:          ;i;:,,,.          :t:   .i1;ii::,;:    ,i;               .;ii;i:
G@88888i,:i111tiL0000GLC0i          ;ii:,,,.          ;f:   ,ii;1i,,;;,   :ii:.              ,iiii;:
C888888t,:;111t1t00080CfL1          :i;:,,,.         :tt,   ,iiif;.:;,.  .; .;.              :iiii;,
LGGGG00L,,:i11t1iG8000GCC1          :i;,,,,.        ;000CLf1111ff,.:;:.  .;;;:              .iiii;:,
C800GGGCft;it111tG8000GGGf.         :i;,,,,.        100088880008Gt,:,:,   :1,               :iiii:,,
G@@@@88000f;Lf11fC8800GGGf. .       :;;,,,,.        f0088000GCLLLt,,.::  ,i,               .iiii;:,,
G@@@@@@@88C:fCt11L88GCGGf1,..       :;;:,,,.       .G0008888CLLff;.,i:. ,::;,              :iiii;,,,
G@888888@8i,1Ltt1t800GCfLL:.....    ,;;,,,,.       .tC008800CLLff,.,;.  :,.;.             .i1iii:,,,
G88880000C:,;1111iGG08GCCC;........ ,;;,,,,.         .,;1tfLLLLLt.,:;:. ;i;,              ,11ii:,,,,
L000000000t,:it11iG@8880GGi ....... ,;;,,,..        .      ,ii;:,.,: ,,,;,,               ;iiii:,,,,
L0GGCCCCGGCi,;fftif@@880GGt....     ,;;,,,..            .. :1i:,..,:;;,:;:             . ,iiii;::,,.
G@8880GGGCfLL1LLf118@880GGf..       ,;;,,,,.               ;i;:,,,..:i,.;, .   ..........;iiii::::,.
L0088@@@8800CtLCf1i08880GGf.        ,;;,,,,.               ;i;:,,,,.:;,;,   .   ........,iiii;:,,:. 
tCCG0888@@@0:;tCL1iG@8000CL,        .;;,,,,.              .;ii:,,,,;:,:,    ..   .......;1iii;:,:,..
1fCG0000GGGL,:;tLtiL00GGGCf,        .::,.,,.              .iii:,,,,,::.      .     .....;iii;:,,,,..
", @"
L0GGi,;tLCCCfLGG0000GGC1..          ,;;;:,,,,.                   ;i;i:,,,,,.           . ........   
C800t:;tLGGGLL888888800f,.          ,iii:,,,,.                  .iiii:,,,,,.          ,;,,.,,,,,.:, 
G@88L:;1fLCGCf088888800L,.          ,iii:,,,,.                  .;ii;:,,,,,            ...,..,...,. 
G@88C::ifCG0GC088888880L,           ,iii:,,,,.                  :;;i;:,:,,.             .,,.,,,,,,. 
L000G;:itCG00LG88888888C: .         ,ii;:,,,,.                  ;iii;:,,,,.             ........... 
fLLLL1;;1CG00LC00000000Gi .        .1t1i:,,,,.                 .;iii;:,,,,                          
C80GCCCttCCCGGGG0000GGGGt,         .1tt1;::,,                  .;i;;;:::,.                          
G@88880CtCCCCCLC00000GGt;,.        .1ftfftt11i;::,...      .:::;i;i;::::,.                          
G@@@@@8G1CGCCLtiC000GGf:.,,.,,:;:,.,1fG0CLfffLLfftt1it1ii;::;tti1tti::::,.                          
G@@@@@Gi;tCCGGCfLC0800Gi.,;;::ittt11tLGGC11LLLLLffftffffffffttt1;i1t1iii:;t:                        
G@@@80i,;1LLLC00LiL800G1.,::,:;i111ttfLLtitLLLLLLLLLLLLLfttttf1it1it1;i:;L1it.                      
G@@@80i:;1LCLLLLfitCGCCt,,:,...,,:;;itLLfitffffffffftttttttttt,,:ii:,,:;;11ff.                     ,
G@@@881,;itLCCLLGCftt1t1:..         ,;11i:i111tt1tttt11111itt:::,:::,,,iiC80t:.                   .:
C88888f,:i1fLffLGGGCCLff1.          ,;ii;iiiiii1iii;iiiiiit01;:.,::::,.,11t1ti.                   :;
fCCCGGf:,;1tttfC000GGGGCL,          .:;:,,,:,::;ii1ii11i1fGL1;1ti,,::,,.  ,:ft.                  .;;
C0GGGGCCf;it1ttL0000CCGGC;          .;;:,,,,      ..,,:tL1tf;,:1CC1,,,,    .1Li                  :i;
G@88880001;ttttfG000GfLLL;          ,;;:,,,,.         .ti ,:,.,,;ft,.,.     ifi,                .;i;
G@@@@@@88t;tt1t1L80080GGC;          ,;;:,,,,.         :t:  ..,;;;;;;;:.    ,i.,:.               :ii;
G@888@@@C;;1ttt1t088800GC;          :i;:,,,,.         ;1,    :ii;;;;::.    ;,.:,               .iii:
G@88888G;,:i1tt1tG08800CC;          :i;:,,,,          11.   .;1iii;:::    .,;1:                ;1ii:
G@888880i,:i11111G0000GG0t          :i;:,,,,.        ,1i.   ,i1ii;;:;:     .i:                ,i1i;:
L8088888i,:;11t11C0000CfCt          :i;:,,,.         :t;    ,ii1i,,:::    ,ii,                ;ii;;:
L0GGGGG01.,;i11tiL8000GCL1          :i;,,,,.        :tf;    :iiti,,i;,   ,;,,:               ,iii;;:
G@800GGCLti:11111L0000GGGt.         :i;,,,,.       ;088CLt1;iitf:.:;,,   :,.;,               :iii;;,
G@@@@@8800Gi1Lt1tC0000GGGf.         :i;,,,,.       t00088888008Gt,:::,   ,1i:.              ,iiii;:,
G@8@8888800f1Lf11f00GGGGL1,..       :;;,,,,.      .L008808000GCCt,,.,:   ,i.               .;iii;:,,
L0GGGGCCGG0GCCCLtt00GCCLft,..       :;:,,,,.      :G0088880GCLLf;.:::,  :i:.               ,iiii;:,,
1fffftttLCCCCGGGCLCCG0CfLf,....    .:;:,,,,.      :LG088800CCLft,.,i,  ,,.:,               ;iii;:,,,
;iiii11tfLftfCCCCCfLG00GCL, .      .:;:,,...        ,;1fCGGGCCL1..:;.  :;:;.              ,iiii;:,,,
1t111ttt11t1itfft1tL080GGC: .      .:;:,,..             ..:111i,.,:,,..;::.               ;1ii;:,,,,
LGCGGGGGGG00GCCCLtf8880GGC; ....    :;:,,,.          ..   .i;:,..,:,:,::,.   . .         ,iiii;,,,,,
fGCG0008@@@8GCCGGLt0880GGCi..       :;:.,,.               :ii:,,,,:i;,,;: .             .;iiii::,,,.
fCCG000000GLffLft1108000CLi         :;:,,,.               :i;:,,,, ;;,::  ..   .   .....:iiii;::,,, 
ittffffftttft11tft108800GCi         :;,,,,.               ;i;:,,,,:::::    .   .    ....iiiii:,,:,. 
;iiiiiii11ttt1itLfiC0GGGCL1.        ,:,.,,.               ;i;,,,,::.:,     .   ..   ...,iiii:,,,,,..
", @"
i;;1LGGCLG00000GC1...          ;i;,,,,,,.                 .iii:,,,,,,.                 .  . ...... .
1;:1LG00L0@@@@@88C:...         ;1i:,,,,,.                 ,1ii:,,,,,,.                ,;.,.,.,,,.:,.
Ci:;tLC0CC88@88880i...         :ii::::,,.                 ,iii:::::,,                  . .,......,,:
Gt,;1LC0GG888888801...         ,ii;:,:,,.                 ,iii::::,,,                    ,,.,,,,:,:;
GC,:iLG00C0@888888L,...        .ii;:::,,.                 :iii:,,,,,.                   ..........;i
fC;:;tC08CG8888888G;...        :t1;:::,,.                 :11i:::,,,.                            .ii
LGCLt1CG00000000000t...        iffi:,,,,.                 :1i;:::::,.                            ,1i
G@880tLGGGG888800Gfi:.         ;ftft11i;:..           ....;ii;:::::,.                            ;1i
G@@@@ftGCf1C0000Ci..,, .,,,..  ,fCGCCLLLLfft1i;i;:,.. :t11t11i:::::,                            .i1;
G@@@CiiCGCtfG8800f,,:;;::1tt1111C80C1tLCCLLfLftLLLLftt1ft:;tf1;;;i;,:,                          :ii;
G@@L::ifC08GtL800G:.:;;:,;i1ttttLCC1iLCCCCCLLLLLLfffffffff1i1L1i1i::fCi;                       .;i1;
G@@f:;itLCCC1iC0001.,:;::,:;i11tLCCtiLLLLLLLLLLLLLLfffL1::1tti::;::1L::C.                      ,iii;
G@@G::;1fGCCLCLffL1,,,..      .,;fft:tfffffffftttttt1ft,,:,;;:,,,iiiCCLt                       :iii;
G@@8i,:itLCLL0GCLfft1,           ;iiiii111ttt1ttttttC1:;:,,:;;:,,:ifGGL1:                     .ii1i;
L000f,,;1tffL0000GGCC;           :i;;;;;ii1tttiiii;fCii::..::::::,.:1itf;                     :iiii;
C0GGGLfiitttfG800CG0Gt.          ,i;,,,,,..,:;;i11LC1:,,fL1:,:;::,,  .,L:                    .;ii;;;
G@88888L;ttttL088GfLCL, .        ,i;:::,,.       tLt;.,.,1LCi,,.,,.    1L.                   ,ii;;i:
G@@@@@@0;iftttG888GCGL, .        ,;;::,,,.      .f1:,,.  .:tt,,:,.    .1t;,.                 ;i;;;;:
G@@@@@@L:;ttt1f888800G;....      .i;:,,,,.      ,fi...   ,i;;;i;:,.   :; .:.                .iii;;;,
G@8888C,,;1ttttG8888GCi....      .i;:,,,,.      ,fi      ,1;;;:,:.    ;,.::                 :ii;;;:,
G@@@@@G:,:i11t1C8000G0L...       .ii:,,,,.      ,fi      :1ii;:i:.    ,;1;.                 ;1i;;;:,
C8888@0;,:;11t1f8080CCG: ...      ;i:,,,,.      ,ti      :1i;:,;:.     :i                  ,11i;;;:,
C800008t,,:i111108880LLi.......   ;i:,,,,.      ,fi      :ti,.:;:.   .:i:                  :11i;;:,,
G@8800GCt1:;1111G8000GCi...       :i,.....   ..:fC1....  :f1,,i;:,   :;,::                .;ii;;;:,,
G@@@@@8880f;tf1tC0000GGf::::::::;i1ft111i;:.   C880CLti;:1f;.,;,:,   ;, ;:                ,iii;;:,,,
G@@@@@@@@80;1Lt1f0888800GGGGGGGGGG00GGCG00GCLf1C00888880G80f;,;:;,   ,1i;.                :iii;;:,:,
C8088888@@LifGGG088888888800GLff11tfft1tLCCC00G008808888800G;.:.::   .i:.                .iiii;:,,,,
L8000008888@@@@@@@88@8888888GCLftiiiii;;:;;itfL088888800GGGL,.::;:  .;;,                 ,iiii;,,,,,
L00088888@@@@@@@@@@@@8880000GGG0GCLftt11ii;;;;;fC088880GGGGf,.,i:.  ::,;.                ;iii;:::::,
L0G00088888@@@@@@@888000GGCCCGGGG0GGGG0008880GCL1;itCG000GGt..,;:.  ::,;                .iiii;:,,,:,
L0G0008888888888800GGGGCCLLfttfLCCGG0080@@@8GLCL1,   .:;itf;.,::,:..ii;,                :1iii:,,,,,,
fGCGGGG0000000000GCCLLLLfft1iii111tLCCGCCCLfi:::.        :;:,,::.:.:;.:..          ... .i1ii;:,,,,,.
tLLLLLLLCCCCGGGCLLffttttt1iiii11111ii1111tfff1.         .;i:,,,:i;,,;;.            ..  ,iiii;:::,,, 
tLLLLLCCCCCCLLftt11111iii11111i:,,,,;;:;;ittti.          :;:,,,,;;,,;,             ..  :iiii::::::..
1ffLLLLCCCCLLft11iiiiiiii1111ii;::,,::.......            ::,,,,,;;:;,               . .;iii;:::::,..
", @"
i;;1LGGCLG00000GC1...          ;i;,,,,,,.                 .iii:,,,,,,.                 .  . ...... .
1;:1LG00L0@@@@@88C:...         ;1i:,,,,,.                 ,1ii:,,,,,,.                ,;.,.,.,,,.:,.
Ci:;tLC0CC88@88880i...         :ii::::,,.                 ,iii:::::,,                  . .,......,,:
Gt,;1LC0GG888888801...         ,ii;:,:,,.                 ,iii::::,,,                    ,,.,,,,:,:;
GC,:iLG00C0@888888L,...        .ii;:::,,.                 :iii:,,,,,.                   ..........;i
fC;:;tC08CG8888888G;...        :t1;:::,,.                 :11i:::,,,.                            .ii
LGCLt1CG00000000000t...        iffi:,,,,.                 :1i;:::::,.                            ,1i
G@880tLGGGG888800Gfi:.         ;ftft11i;:..           ....;ii;:::::,.                            ;1i
G@@@@ftGCf1C0000Ci..,, .,,,..  ,fCGCCLLLLfft1i;i;:,.. :t11t11i:::::,                            .i1;
G@@@CiiCGCtfG8800f,,:;;::1tt1111C80C1tLCCLLfLftLLLLftt1ft:;tf1;;;i;,:,                          :ii;
G@@L::ifC08GtL800G:.:;;:,;i1ttttLCC1iLCCCCCLLLLLLfffffffff1i1L1i1i::fCi;                       .;i1;
G@@f:;itLCCC1iC0001.,:;::,:;i11tLCCtiLLLLLLLLLLLLLLfffL1::1tti::;::1L::C.                      ,iii;
G@@G::;1fGCCLCLffL1,,,..      .,;fft:tfffffffftttttt1ft,,:,;;:,,,iiiCCLt                       :iii;
G@@8i,:itLCLL0GCLfft1,           ;iiiii111ttt1ttttttC1:;:,,:;;:,,:ifGGL1:                     .ii1i;
L000f,,;1tffL0000GGCC;           :i;;;;;ii1tttiiii;fCii::..::::::,.:1itf;                     :iiii;
C0GGGLfiitttfG800CG0Gt.          ,i;,,,,,..,:;;i11LC1:,,fL1:,:;::,,  .,L:                    .;ii;;;
G@88888L;ttttL088GfLCL, .        ,i;:::,,.       tLt;.,.,1LCi,,.,,.    1L.                   ,ii;;i:
G@@@@@@0;iftttG888GCGL, .        ,;;::,,,.      .f1:,,.  .:tt,,:,.    .1t;,.                 ;i;;;;:
G@@@@@@L:;ttt1f888800G;....      .i;:,,,,.      ,fi...   ,i;;;i;:,.   :; .:.                .iii;;;,
G@8888C,,;1ttttG8888GCi....      .i;:,,,,.      ,fi      ,1;;;:,:.    ;,.::                 :ii;;;:,
G@@@@@G:,:i11t1C8000G0L...       .ii:,,,,.      ,fi      :1ii;:i:.    ,;1;.                 ;1i;;;:,
C8888@0;,:;11t1f8080CCG: ...      ;i:,,,,.      ,ti      :1i;:,;:.     :i                  ,11i;;;:,
C800008t,,:i111108880LLi.......   ;i:,,,,.      ,fi      :ti,.:;:.   .:i:                  :11i;;:,,
G@8800GCt1:;1111G8000GCi...       :i,.....   ..:fC1....  :f1,,i;:,   :;,::                .;ii;;;:,,
G@@@@@8880f;tf1tC0000GGf::::::::;i1ft111i;:.   C880CLti;:1f;.,;,:,   ;, ;:                ,iii;;:,,,
G@@@@@@@@80;1Lt1f0888800GGGGGGGGGG00GGCG00GCLf1C00888880G80f;,;:;,   ,1i;.                :iii;;:,:,
C8088888@@LifGGG088888888800GLff11tfft1tLCCC00G008808888800G;.:.::   .i:.                .iiii;:,,,,
L8000008888@@@@@@@88@8888888GCLftiiiii;;:;;itfL088888800GGGL,.::;:  .;;,                 ,iiii;,,,,,
L00088888@@@@@@@@@@@@8880000GGG0GCLftt11ii;;;;;fC088880GGGGf,.,i:.  ::,;.                ;iii;:::::,
L0G00088888@@@@@@@888000GGCCCGGGG0GGGG0008880GCL1;itCG000GGt..,;:.  ::,;                .iiii;:,,,:,
L0G0008888888888800GGGGCCLLfttfLCCGG0080@@@8GLCL1,   .:;itf;.,::,:..ii;,                :1iii:,,,,,,
fGCGGGG0000000000GCCLLLLfft1iii111tLCCGCCCLfi:::.        :;:,,::.:.:;.:..          ... .i1ii;:,,,,,.
tLLLLLLLCCCCGGGCLLffttttt1iiii11111ii1111tfff1.         .;i:,,,:i;,,;;.            ..  ,iiii;:::,,, 
tLLLLLCCCCCCLLftt11111iii11111i:,,,,;;:;;ittti.          :;:,,,,;;,,;,             ..  :iiii::::::..
1ffLLLLCCCCLLft11iiiiiiii1111ii;::,,::.......            ::,,,,,;;:;,               . .;iii;:::::,..
", @"
t0GfLCGGCfCG000000C1,..         ,ii;,,,,,.                  :1ii:,,:,,,                . ....,.,.. .
C@8CC008GCC088@@880f,.. .       ,11i:::,,,                  ;11i::::::,               ,;,,.,,:::,:,.
G@8ffG080LLG088888GL:...        .i1i:::,,,                  ;11i:::::,.                . .,,,,...,,:
G@f:ifG00GC08888880L:....       .i1i:,::,,                  i1ii:::::,.                  ,,.,,:::,:;
C@t:;1CG0GLG@@@@@880i....        i1i:::::,                 .ii1i::::,,.                 ..........:i
G@G:;ifCG0CC@@@@8888t...         ;11;::::,                 .i1i;:::::,                      ......;;
G@0;:itCG0GG8@@@8888L,..         :11;::::,                 .iii;:::::,                    .......,ii
G@81,;1C080C8@@@@@@8G:...        :1i;:::,,.                ,1i1i:::::.                    .......:1i
fGGf;;iLG00CG88888880i ..       .1ft;:::,,.                ,11i;:::::.                   ........;1i
C0GGCL1fG000008800000L,...      .1Lf1;;::,                 ,iii;:::::.                    ..... ,11i
G@@888ffGGGGG0888800L1:.         1LfLLfftt1i;::,,..    .;i;11ii;::::,                      .... :11;
G@@@@@G1GGCL1f00000L:.,:,,,;i;::,1L80GLLLLCLLfLt1Lftti;;1L1i1ff;;;;;,,                      ....;ii;
G@@@@0t;LGGGLLC0880Gi.:;;::itfttttC00L1LCCCCLLLfLLLLLLLffff1i1ff111i:tL;.                    . ,ii1;
G@@@0i:;tLCG00t10800f.,;;::;i11ttfLCCt1CCCCCCCCCLCCCLfffff1ittttiii:1Ci1L                      :iii;
G@@@0;:i1LCCCCf1LGGGL,,::,,.,,:;iitCCfifLLLLfffLffffffttLi,,;11:,,;iiLLfL                     .;iii;
G@@@8i,;1tCGCLGCffftt;:,.         :1t1;ittttttftftttt1tLi::::;;::,,itC80t:                    ,i11i;
G@@@@f,:i1fLLfG0GGCLff1.          ,iiiiiii11ttt1iii111GGii:.,:;:::,,;11tfi.                   ;i1ii;
LGGG0C;:;1ttffG000GGGCL, .        .;i:::::::;ii1i1111LCti:LLi::;;::,. .,ft                   .iii;i;
C0GGGGCLi;tttfC0880CGGG; .        .;i::::,.    ..,,1LtL1,,:tCCi,,,,.    :C;                  :iii;i:
G@@88888L:ttttfG888CfCCi .        ,i;::::,.        if:;:,..,:tf,,,,.    ;f1:.                ;iii;;:
G@@@@@@@G:1ftt1L8888GGGt...       .;i::::,.        1t,.,. .;i;;ii;:.   .i. :.               .iii;;;,
G@@@@@@@f:ittttt0888000f...       .ii:::::,        tt,    .i1i;;:::.   ,;,,;.               :1ii;;;,
G@@@88@C,,;1ttt1G88800GL,         .ii;::::,      ..tt,    .11ii;:i:     :ti,                ;11i;;:,
G@@@@@@C,,:i11t1C8000GG0i ...      i1;:::,.       .tf, .. ,11i;;:;;     .i,              . .i1ii;;:,
C88888@0:,:;11t1f8000GfC1..........;1;:::,.       .tf, .. ,111:.;;:.   ,ii,             .. :11ii;::,
C0GGGG00i.,;ii11100000CL1......    :i:,,,,. .....,fCf:,,. ,itt:.i;:.  .;.,;.           .. .;iii;;::,
C8000GGGLti,i111tG0000GGf,..  ..:;itfftfffLCCCCCLC8880CLf11fC1,,;::.  ,;.,;.            . .iiii;:,:,
LGGGGGGGGGC1ift1tC8000GCL,.:;1LG088800000CCCCGGCLGG0888@@@888G1,;:;,   ;1;,             . :iii;;:,:,
L0GGGGGGGGGGGGGCLC000G0GGLG08@@888888880GLt1i1t1iL088888800GGG1.:.::   ;;.                ;iii;::::,
LGGGGGGGGGGGG008888888@@@@@@@@@@@@888880GGGGLt1i;f00888@8GGGCL;.:i;,  :i;,               .iiii;::::,
LGGGGGGGGGGGG0088888@@@@@@@@@@@@@88800GGG00000GGG000888GG0GGCL:.,i:. .:.::               :iiii;::::,
LGGGGGGGGCGG000000888888@@@@@@880000GGCLLLLGG0000888@@8CfCGGCf,.:;:. ,i:;,              .i1iii:::::,
LGGGGCCGGGGG0GG00008888888888000GGCCCLft111ttLCG000GGCLi:,,:;;,,::,:.:i;:.     .......  .11ii;:,:,:.
LGCCCCGGGGGGGGGGGG000000008800GCLLLfft1111111111fftffff;...,,,,,:::;,;:,.     ........  :111i:::::,.
tCLLLLLLLLLLLLLCCLLLLCCLLCCCLfttt111iiiiii;;i;:;;;;11tfi..,,:,,,,:1:,:i:      ...   .  .;iii;:::::, 
", @"
C8088880000CLCGGGCfL0G00000Gf,..         ;ii;:,,,,.                  ;11i;,,:,,,       . ......,....
G@@@@@@@@@@CtG088CLC08@@@@80L,..         ;11i:::,,.                 .i111;:::::.      ,;.,.,,:::.:,.
G@@@@@@@8@C:;fC080CC8@@@@@80L:...        ;11i::::,.                 .111i::::::.       ...,,.,...,,.
G@@@@@@@@@G;;1LG00GL8@@@@@880;...        :11i::::,.                 ,111i:::::,         .,,.,,,,:,, 
G@@@@@@@@@@i:ifCG00L0@@@@8@881...        ,11i::::,.                 ,iii;:::::,         ........... 
G@@@@@@@@@@t:itCG80G0@@@@88@8t...        ,11i::::,.                 ;iii;:::::.               ...  .
L0G0000888@C,;1C088CC@@@@@@@@C,...       :11i:::::.                 i111;::::,.             ....    
G88800GGCCCL1;ifG88GC08888888G: .        1ff1::,,,                  i1ii;::::,              .     . 
G@@@@@@@@8000GtLGG000088888000t,..      .1Lft1ii;:.             ...,iiii;::::,              .       
G@@@@@@@@@@@8@Lt0GGGCC080800G1::.  .     iLLCCCCLfftt11i;:;,,.. :1t1t1ti:::::.                      
G@@@@@@@@@@@@@CiGGGGC1t08800C:.::::;1t1i;tL080LtLLCCLLLLtfCLLfttttf1;1ftiii1;:1,                    
G@@@@@@@@@@@@L;ifCC00GGLG@8801,:i;:;1tttftfCCLitCCCCCLLLCCLLLffffffft1itf11;:fLit.                  
G@@@@@@@@@@@8;:itCCCG0G110888f.,;::::ii1ttfCCCifLLLLLLLLLLLLLffffL1,:1t1:,:;;ttiC,                  
G@@@@@@@@@@@@1:i1LGGCLCLtfLLCf:,,..    ..,;tffi1ffffffffffttttt1ft::::;::,,iit08L;                  
L00888@@@@@@@f,;1tLCCfG0GCLfft1,         .:i11iii11tttt11111t1ifC;i:.:;;::,.;tttft,                 
C80GGGGG00088C,:itffLLG80000GCL:...       :ii;;;;;;;i11ti111i1fCf1i1i:,:;;:,. .,1L,                 
G@@@@8000GGGGCf1;1fttfG8880C0GGi .        :ii;::,,   ..,,,:1Lf1fL;:iLCt:,,:,    ,Lf.              . 
G@@@@@@@@@8888881;fttfL0888LLCG1 ..       :i;;:::,.      ,1fi. :i,,,:1G1.,,.    .tt;,               
G@@@@@@@@@@@@@8@L;tftttC8888GGGt..        :i;;::,,.    ,tfi.   .,.,iiiti,,,     ;: :,               
G@@@@@@@@@@@@@@81;1ftt1f8888800f..    ....;ii;:::, ..:tLi.        :11i;,,,.    .i,,;. .             
G@@@@@@@@@@@88@f,;ittttt088880Gf,.... .   :i;:,,,:tCCL1,         :1t1;;::,.     ,11. ..            .
C888@@@@@@@@@@@L,:i11tt1G8880G0G: ..    ..itt1iif0888Ci,.  .   :1t1i:;:,,,.     :1, ..            .,
C8000000888@@@@C,:;11tt1C8880CLGi.,:;itLGG0GC0008888000Li,. .ift:,;::i,,,,.   .;i;,           . . ,;
G@@@@88800G0000G:,:i11tif8888888000800GCCCCftL0008@@80G0GLt1f1:  .;ii;,,,,    ;: ::             . :;
G@@@@@@@@@880GGGLt;;t1tfG8@@@@@@@@@80CLLft11;:iC8888@8CLCG0Gi    .ii::,,.,.   ;;:i.            . .ii
L000088888@@@@8888CL008@@@@@@@@@8880GGGG0GGGC008@@0LCCLLLLt;.    .;:;:.,..    .1:.             . :1;
C000000000088888@@@@@@@@@@@@@@88800CLLLCGGG088880GLffLLft1,      ,;:;;,,,.   ,i;                .;i;
L000000000888888@@@8@@@@@@@88000GGCLt111tfLLLLfti;;;;1i:,....    ,::;;,,,.  ,:,;,               ,ii;
L0GGGGGG0000888888@888888880GGCCCLft1iiii1ii111111111tfLL; ..   .,,1i:,,..  :;,;.              .;1i;
LGGGGGG00000008888888088800GCLffftt1ii111ttttffffffffLCCL; ......,,;;:,,.   ;ii,.......        ,111;
fGGGGGGGGGGGGGGGGGGGGCGGGCLfftt11111i111t11tt1ii1ttt1:,,. ....  .::;:::,.. :;,,........ . .....;1i1;
fGGGGGCCCCCCCCLCCCGGGGGCLftt111tt111tttfti1tttffLCGGC:  .....   .::;::;,. ,:;; ...   .  ......,iii1;
fCCCCCLLLLLLLLCCCGG0000GCLffffffttt1fffftLLLLCGCCLft;.......... .::::i1;.:i,;.  ..  ..  ......;1iii:
fCLLLLLLLLLLCCCCGG000GCCLffLLLffftttLLttffttt1i;;,.  .. ....... .:::,,:;;;;i,   ..   ..   ...,1111i:
tfffffttfffffffLLCCCCLfffffffttt111tti:,,..::..... ..      ..   ,:::::,,::,,     .   ..    ..;iiii;,
", @"
L0GGGCC1LGftLLCCLftCCG00GGGCt,           ,;;;,,,,..                  .;ii;:,,,,,.      . ........   
G@88880C00GfCCG0GLfG0088880Gf,           ,i;;:,,,,.                  .;ii;:,,,,,.     ,;.,.,,,,:.,, 
G@@@@@@@@@0tLC00GLfLGG88800Cf,           ,i;;:,,,,.                  ,iii;:,,,,,.      . .,..,...,, 
G@88@@88881:1LGG0CLC0088880Cf,           ,iii:,,,,.                  :iii;,,,,,.         ,,.,,,,:,. 
C@888@8000i,itCGGGfL88888800G; .         ,ii;:,,,,.                  :iii:,,,,,.        ........... 
G@88888888t,;1fCCGLf08888800Gi .         .iii:,,,,.                  ;;;;:,,,,,.                    
G@88888888L::ifLGGCL0888880001 .         .;ii:,,,,.                 .;;;i:,,,,,                     
L0000888880::ifCG0GLG88888880f. .        ,ii;:,,,,.                 .iiii:,,,,.                     
fCCCLLLCCCCi::1LG00fC00000000C, .        itt1:,,,,.                 ,ii;;::,,,.                     
G@8800GGCCLLf11LCGGGGGGGGGGGGG1.         ;tf1i;;::.              ...:i;;;:,::,.                     
G@@@@@@888000C1CCLCCCC00000GGLi,.        ;tfffffftt11ii;::::,,. .;11i111;::::,                      
G@@@@@@@@@@880iLGCCLf1fG0GGGL;.,,.,:;i;::itL0GLtffLLLffft1fffftt111t;;ittiiii,;1,                   
G@@@@@@@@@@@8L:tCLCGCtfC0000G1.:;;::ittttttLCCtifLCLLLffffffffffffttt1i;ttii::fti1                  
G@8@@@@@@88@f,:ifLfCG0G1t0000f,,;:::;i111ttfLL11LLLLLLLLLfLLffttttfi,:i1i:,::;1i1f                  
G@8@@8@@@888t,;itCLLLLL1iLGGCL,,:,,...,:i;itff1;tttttttttttttttt1t1,:::::,,.;i100f:                 
C@88@@@@888@L,:;1fCCLfCCftt111;,.      . :0000GGGGGGC1tt1111111i1C;;:.,:::,..;111t1,                
fCCG008888880:,;itffffGGGCLLfft.   ..,:::t@@@@@@@@@@0CG00000000GGfiiif1:,::,.. .,if,                
LGCCLLLCCCGGGi,:i1tttfG0GGCCCCLiitfLG000C0@@@@@@@@@@t,,:;iii1tttfLi,ifCGL;,,.    ,ff,               
G@8800GGGCCCCLf1:1111fC000GG0GG00GCLfCGGC0@808@@@8881....       :i:,..,;G0;.     .11;.              
G@@@@@888800000L:1fC00888@880CCCCCLfLC008@80ff08@8881........   .,,,:::.:@L.     ;: :,              
G@8@@@@@@@@@@88Gf0@@@@@88880GCCCCGGGG0880GLtitLCGGG01,,..          ,::,:fGi.    .;,,:.              
G88808888888@@@@@@@@@@88880GLffftfLLLCCCft11ttffLCCGGGGGGGCLf111i1iitfC0C;..    .,1i.               
G@8880888888@@@@@@@@@8800GGLft1iiii11ii;;;;i;;1tftii:,:::;;;;1ffttftfLfi,.,.     :i.                
C8888888@@@@@@@@@@8800GGCLLft1i;;;i;;;;i11tti1fLCi           ,:,;:;;:,..,,.    ,;;:.                
G@8888@@@@@@@888000GCCLfffft1i;;;;ii1tttttttfLL1:. .          ,:;.,::,,,,,.   .;..:.               ,
C88888888@@8880GGGGGLfftt11ii;;;;ii;iiiii1tfCCL;..            ii:..,,,,,...   ,:,::               .:
C80088888@8880GGGGGLftt1ii;;;;;;i11;i11tfffft1:...            ;,,,.,,,,....    ii,.               ,;
L00000000GGGGCLLLLftt1iiiiiiiii1111itftfft1i:.....            ::;,.,,,,...   .,;.                 ;;
fGGGGGCCLLLCCLLffftt1iii111ii1i11111ft1;,..::,....            ,,,:,,,,,,..  .:::,                ,;;
fCCCLLCCCCCCCCCCCLftt1111111111tt1i;:.    ,::,....            .:::,,,,,...  :. ;,                ;i;
tLLLLCCCLCCGGGGCLfftttttttt11ii11,.   ....,::,....             ,i,,,,,....  i;;,                .ii;
tLLLLLLLLCCCCCCCLfttttttt11iiitft. ....   .::,....              ::::,,...  :::, ..              :ii;
tLfffffffLLLCCLfttttttt1111tLCGCL, .      .::,....              ,:::,....,:::.                 .;;;;
1fttttttffffffttttttttttit0880GCL:        .::,...                ,:;:,,.::.;: ..   .    ...... :i;i;
it1tfLLLCCGGGGGGGCCtitf1;1GGGCCLf:        .::,...                ,:;:,,;;,:,            .......;;;;:
", @"
1t1111i::ifCCCftfGGG0000GC;            :;i:,,,..                   .11;;,,,,,,.        . ........   
LGCCLLLLttLGGGLfLG0888880Gi .          :;i:,,,,,                   ,11i;,,,,,,        ,;,,.,,,,,.:, 
C800GtC0CfCCGGCffG0888800Gt.           :ii;,,,,,.                  :iii:,,,,,.         ...,..,...,. 
G@888G00GfCCG0GLfC0008800Gf,           :ii;,,,,,.                  :i1i:,,,,,.          .,,.,,,,,,. 
G@@@@@@@01fCG0GLfLGG88800Gf,           :ii;,,,,,.                 .;iii:,,,,,.          ........... 
G88@88881,ifCG0CLC8888880GL,           ,ii;:,,,,.                 .iiii:,,,,,.                      
C88@80001,;1LCGGLf08888880Gi           ,iii:,,,,.                 .;ii;:,,,,.                       
G8888888L,;ifLCGCt0888888001 .         .iii:,,,,.                 ,;;;;:,,,,.                       
G@88@8880;:itLC0GCG88888000t. .        .;ii:,,,,.                 ,iii;,,,,,.                       
L0GG08808i,;1LG00LL88888880C, .        :1ii:,:,,.                 ,iii;:,,,,.                       
LGCLLLLLLt;:ifC00LLG0G000GGG; .        ;tt1:,,,,                  :;;;::,:,,.                       
G@88800GCCCfiLCCGGGGG000GGGGt,.        :tttt11ii:,,,....      .:;:ii;i:,,,,,                        
G@@@@@@888001fGCCCLLG0G0GGGt:,.  ..... :tfCCLLfffffftt1;t1ii;::;1t;i1ti::;;,,.                      
G@@@@@@@@@88t1GCCCLi1G00GGCi.,::::i111i1tL0GL1tLLLLfffftfffffffttt1iiit1ii;:ft;,                    
G@@@@@@@@@8t:;fLLCGLCfL0000f,,;;::;i11tttfLLtifLLLLLLLLLLLLfttttf1;i1i1;::,if:1t                    
G@@@@@@@88C,:;tCffCGG1;C000C:.::,,,:;;i11fLLCLCCLLffffftttttttt1f:,::;:,,,i:1GGt.                   
G@888888880::;1LCLLfLf1tffff;,,.....    ,;118@@@@@88000C1111iiiL;::,::::,.,itLLti.                  
C888@@@8888i,;itfCLtCGCLftt11:     ..,:;i1tL@@@@@@@@@@@0CGGGCLCL;i::::,,,..,.::1t.                  
fCLCGG00008f.,;1tfffLGGGGCCLL1:i1tfLCC0000G0@@@@@@@@@@G;:;1ttfLf1:tCCCCLti,    :fi                  
C0GGCCLLLLLLi;:it11tL000000000GGGGGCLffC008@@0C0@@@@88L,......:f;.,,:;iitC0t,   tf;.                
G@888000GGGGGG;;11fG88888@@@80GCCGGGCCG08888GL1L08@888t.....  .:,,,,,,....i8G. :;.:,               .
G@@@@@@@@88800tiC0@@@@@@88880GCLLLCCCCGG0GCf11fCGG0000i..       ..:::,,,,, L@i ;,.:.               :
C@88888@@@@@@808@@@@@@@88800GCftt11tttfftt1iii1ttfLCGGCGCCLf1i:,.,::,,....18L..,;i,               .;
C880080888@@@@@@@@@@@8800GGCLft1i;;;ii;;:i1i1i;itft;;;,,:i1tt11LLftt111tLGG1.  .;,                :;
C888888@@@@@@@@@@@8800GGCLLfft1ii;;i;ii1tffft1tfff1.          .iiiii11111;.   ,;;.                ;;
C@88888@@@@@@88800GGGCCLffttt1i;;;;i;i11i111tfLCt.            ..,;;:;;,..    ::.:,               ,;;
C888888888@@@8800GGGGCLftt11ii;:;;ii;;iii1ttfLft;               :i:,,.....   ;, :,               :;:
C8000088888800GGCCCCLftt1ii;;;;;ii1tiit1tfffti;,.               ii:,,....    .i;,               .;;;
L0G00G000GCCCCLffffftt1iiiiiiiiii111i1ftt1i;,....              .;,,:,....    .;.                ,;;;
LGCGGCCCCLCCCCLLLLLft11111111i1i1tt1i1i:.,::,....               ::;;,....   ,;:.                :;;;
fCLLLLLLCCCCCGGGGCLLfttttttt11111f1:,.   ,::,....               .:,;,....  ,: ::               .;;;;
tLLLLLLCCLLCCCGGCLfftttttttt1iiii;.   .. .::,....               .:;;,....  ,:,;,               :i;;:
tLLLLLLLLLLLLCCCCLfttttttt1iii1t,  ..... .::,....               .:i:,...   :;:,               .;iii:
1LfffffffffffLLffttttttt11tfLCGL,..      .::,....               ,::::,... .;,,                ,i;;i:
it111111ttffffttttt1111iiCGGGCLL;        .,:,....               ,:::,:,. .:,;. .       .......:;;;;,
", @"
1ttt1iifCCGLffGG000000G1...          :;i:,,,,,.                   .iii;:,,,,,.         .  ........  
LGLCGCfLG00CLLG08888880L:..          ,iii,,,,,,                   ,11i;:,,,,,.        ,;.,.,,,,:.:, 
C8Cf00LLCG00CfC08888880Li...         ,iii:,,,,.                   ,i1i;:,,,,,.         . .,..,...,, 
G@8888GLCG00CLfG0088800G1...         .iii:,,,,,                   :iii;:,,,,,.           ,,.,,,,,,. 
G@@@@@CifC00GLfG0888880Ct..           iii;,,,,,.                  :iii;,,,,,,.          ........... 
G@8880i:ifC00GLG88888880C:..          ;ii;:,,,,.                  :iii;,,,,,,                       
G@8888f:;1LGGGCf888888880t...         ,iii:::,,.                  :i;i;:,,,,.                       
G@@@8@0::;tLC0GL0@8888888f...         .iii:,,,,.                  :iii;,,,,,.                       
G@@@@881,;1LG00GG88888888G:..         ,iii:,:,,.                  :1ii;:,,,,.                       
L000008C,:;fC08GL088888888t...        :tt1:,,,,.                  :ii;;::::,.                       
L0GCCCCLti;1CG00CG0000000GC:..        :tfti;;::,.             .::,ii;;::,:,,.                       
G@@@8800GGL1CCGG0000800000G1,..       .tffLfLfftt11iii;;;::,,.,if111t1;:::::,,                      
G@@@@@@@888tfGCGCLL00000GC:,:,..,:;;:,:tL00GLtLLLLffffttLfffttt1tti;i1t1iii:;L1:.                   
G@@@@@@@@@@fiCCCCf;f0000GL;,,:;;::1fttttfGCCi1LCCCCLffLLLffffffftf111ift;i::ft,fi .                 
G@@@@@@@@@t:;tLLGGGCfL8000t,,:;:::;i111tfLLf;1ffLLLLLfLLLfffftttfi,:i1i:,,;;;fLC1  .                
G@@@@@@@80;:;iLLLCGG1;C00GC:,:::,,,;tLG000GGftfffttttffft11111itt,:;::::,,,i1C0Ct;.                 
G@@@@@@@8@t,:;1LCCLLLftffff;,,.,iL08@@@@88888800GGCLLGGG0GGGLfLC:;1;,,:::,,,:;iif1....              
C888@@@@8@G,,:;tLLffGGCLfttfttC8@@@@@@@80GGCCGG008880G0@@@@800Gffti:fffft1i;,,,,if:..... .          
L0GG0008880LffLLCCCCG0000888@@@@@@@@@@8GGLt1tffLCGG00GCG8@@@80ttCfLLLffLLCCGGGCLLGL:......  .       
C80000000888888@88@@@@@@@@@@@@@@@@@800GLLti;:;;iiiLCCGGGGG0@80G0GGCCLf1:,,::::;itLG8f:......        
C00000000000088888@@@@@@@@@@@@8880GGCLLftti;;;;;:;i1tttfCG088880GLfffft;::,.... ,;,t@C:.....        
L0000GG00000088888888888@888800GCCLffft11i;;;ii;ifC080GC8@@@@8800GCLLfLCGCf:....:;::G8i.....        
LGGGGGGGGGGG000000888888880000CLfftt11ii;;;iii;iii1tL0@@@@@@@880000000000CLL; . .,if88;.......      
L0GGGGG00008888880000G0GG000GLft11ii;;;iiiiiiiiii1i1L88@@@@@@888888888880Cttt:;i1LG8C;.......     . 
L000GG00GGGGCCLLffftttLfLLCLf111ii;;;iiiii1i;ii11tC8@@@@@@@@@888888888800Ctti:itff1;........        
LCCLffffftt111i111111ffLCCCLft1iiiii111ii1ii1i1tL088@@@@@@@@@88880088000CLtt11:., .:......         .
tLfffttttt111111111tffLCGCCLft1111111111tiittffG88@@@@@@@@@@888800000000CLLftff;,,::......        .,
tLffttttt1t11111111ttfCCCLfftttffffftt1ttiffLLC88@@@@@@@@@@8888000000000GGGCCLti:;,...            .,
1tttt1111iiiii1tff1ittttt111tffffttt111titLLtL888@@@@@@@@@888000GGG000000GGGGGf;,:... ...         .,
i111ii111tfCG88@@8i:Lf1it0CLft11111iii;;;ii;t8888@@@@@@@88800000GGG000000GCGGCfi,:,...... .     . ,:
ittfCG00888@@8888L.,it11iGGGGLtft,,,,,..,..i08888@@@@@@8800000000GGGG000GCCCCLLf;.:..   .    . . .::
C800000888888000GL:.:ii1if0G0GCLf:........:08888@@@@8888000000000GGGGG00GCCCCCCCLt:.   .  .......,:,
G@@@880000GGGGGGG0L,,;11118800GCCi.,......C@8888888888800000000GGGGCGG00CCCCCCCCCCt.   ..   .....,:,
G@@@@@@@@@@880GGGGCt1ifLtiC@800GGf,......f@8888888888800000000GGGGGG000GCCCCCCGGCCt,.  ...   ....,:,
C808800008888800GGCCGttLtit00GGCLf:.....100000000GGGGGGGGGGCCCCCCCCCCCLLLLLLLLLLLt,     ..     .,,:,
", @"
fG1fGftfLCCLtfCGGGGGGCf:           .i;;,,,...                   .;i;:,,,,...           .  . .....   
G@0080fLCGGCLfGG00000GC; .         .ii;,,,,,.                   ,i;;:,,,,.,.          ,;.,.,.,,,.:, 
G@@@@0itCG0GffCG00000GLi..          ;ii:,,,,.                   ,i;;:,,,,.,.           . .,......,. 
G@8881,;1LGGCfL0000000Gf.           ;ii:,,,,,.                  ,;;;:,,,,,,              ,,.,,,,,,. 
G8000f,:ifCCGLf08880000C;           :ii;,,,,,.                  ,;;;:,,,,,.             ....... ... 
C@8880::;1fLGCfG8888000Gi .         .ii;,,,,,.                  :;;;:,,,,,.                         
C@88881,:ifCGGCC88880000t..         .ii;,,,,,.                  :ii;:,,,,,.                         
L00008C,,;tCG0Cf00088000G:          :tii:,,,,.                  :i;;:,,,,,.                         
fCLLLLLi::ifCGGLCGGGGGGGG1          :tf1:,,,..                . :;;;:,,:,,.                         
C800GGCCCfiLLCGGGG000GGGGf:..       ,tt1t111ii;::,,,,..     ,ii;1iii:,,,,,.                         
G@@@8880001tCLCLfC0GGGGC1,,,.       .1fCCLLffffffttti1t1t1i;;iti:;1ti:;;;:,i:.                      
G@@@@@@@88f;CLLLi;L0GGGCi.,,,,,..   .iL0GLi1fLLLfftttffttttttttt1i;;t1ii:,1f;i;                     
G@@@@@@@@L::tLCGLLffG0GGL,.,;1tt111ii:iff1:1tttttttfLLLLLfttttt;:i11i:,:::1i,ti                     
G@88@888G,,:iffLCGf:1GGGG;.,:1ttttt1;,,1ff:i111ttttffffffffffL1,,:;i;:::;;:C8Ci.                    
G@8888880;,:;tLLffft1ffff1,,,:;i111i;,:;i1::ii11ttGGGCCCLLftL1:::;i111111t11tt1;.                   
C@8888888t.,:itLLffGLft111i,..    ..  ,;::::::;;iG@@@@@@@8000t1iiiiiii;;i1;..,1i .                  
fGG000888G,.,;itftfGGGCCLfLi. .,;1tfttLCCLLLLLCCG@@@@@@@@@@01i1tLCGCCCCLfft1:,:1, ..                
LGCLLLCCCC1:::i111fC0GGCCCCf:iC0888888GLCGLCCCC0@@@@@@@@@@@C;:,.,:itLG00GCLLfLCCL;...               
G@800GGGCCCCL:;111tfGGGGtfCG0@@@8@@888GGGGGCCCLG08888@@8GC0t,,:1C088880GCLfttti;t0C;...             
G@@@@@88800001,11111C0G0008@@@@@@@880GCCCCCCCGCGG00000GCt1f:;tG8@@888800GCfft11i;i@G:...           .
C8888@@@@@@80f;tftfLG88@@@@@@@@88880GLfft11tfffLCCGCLt1iiftf08888888880GGGCCLfLGCtG@;...           ,
L00008888888800888@@@@@@@@@@@@88800CLt1i;:::;;;;iii;;:iL0008888888888000000000GGCftC,...          .,
L0000000088888888@@88@@@@@88800GCCLft1i;:,,::::,::,,,;C888888@@888@@@000000088880Ct:....          .:
L00000000888888888888888800GGCCLft11ii;:,,:::;::;;::10888888@8888888800000000000GCt. ..           ,,
LGGGGGG000000000088000GCCCCLftt11ii;;::,,::::::;;;:f8888888@8888888800000G000GGGLt1i, .          .,,
fGCCCGGGGGGGG000800GGGCCCCLt1ii;;::::::,::;;;:::::t88888@@8888888880000GGGGGGGGCLt11i.           .:,
fGCGGG00GGGGGGGCCfffffffff1i;;:::::::;;:;iii;;iiit8888888888888888000GGGCGCCCCGCLLft1:           ,:,
fCCCLLLffttt1111ii1111111ii;;::::;;;:;;:;;i;;111L88888888888888800GGGGGCCCCCCCCCCCLCLt.          ,,,
1ttt111iiiiiiii111ttfffft1ii;;;;;;;;;i;;iii;i11f8888888888888800GGGGGGGCCCCCGGGGCLCCLf:         .,,,
1ttt111111111111tttfffft11iiiiiiii;;;i;ii;;:,,i088888888888000GGGGGGGGGCCCCCCCCCLLLLft: .       ,,,,
i111111111iiiiiii1tffft1i;;iiiiii;;;;:,,.:;,.;08888888800000GGGCCCCGGGGCCLLLCCCLfffftti..       ,,,,
i1iiii;;;ii11ttfft:;i11iitt11111:,,......:;,i0808080000GGGGGGCCCCGGCCCCCLLLLCCLLfffftfft,   ....,,,,
;iii1tLCG0000GCCCt1iiLt1i0800GCC:....... ,;t000000000GGGGGGGCCCCCCCCCCCLLLLCCLLfffffLfLLi    ..,,,,,
fG088@@@@@@@@@888G0C1LLt;L000GCLi.......,tG0000000000GGCCCCCCCCCLLCCLLLCLLCLLfffttffLLff:.    .,,,,,
C80880000GGGG00088G;:tL1;1GCCCLfi.....,iLGGCCCCCCCCCCLLLLLLLLLLfffffffLLLfftttt111tttt1, ..   .,,,,.
", @"
fL:.,:ifLLf1fGGGGGGGCf:               .,::.....                    ii;:,......         .  . .....   
1f1,,:iLGGLtfG0000000Gi               .,::......                  .ii;:,......        ,;.,.,.,,,.:, 
1ttfti1LCGLttLG00000GG1.               ,::,.....                  .;;;:,.....          . .,..... ,. 
LCtLGftLCCCftLGG00000Gf,               ,::,.....                  ,;i;:,.,...            ,,.,,,,,,. 
L0LL0CtLCCGLffGGG0000GL:               ,::,,....                  ,;;;:,.....           ....... ... 
G@@@88tfLGGCftLCG000GCL;               ,:::,....                  ,i;;:,.....                       
G@8@8f,;fLGGLfL000000GLi               .:::,.,,.                  ,;;;,,,,...                       
G8GGGi,:ifCCCfL000000GGf,              .:::,,,,.                  ,;;;,,,,...                       
C8000L,:;tLLCLtG000000GC:               ,::,,,..                  :;;;,,,,..                        
C8800G:,:ifLGCfG0000000Gi               ,::,,,...                 :i;;,,,,..                        
C888081.,;fCGGLL00000000f.             .;i;,,,..                  :;;::,,,,.                        
tCLLCCf,,:1LCGLtGGG000GGC:             .;1i;::,,.             ....:;:;,,,,,.                        
L0GCLLftt;iLCCCCCCCCCCCCCt.            .;ittttt111ii;;:::,,.. ,i1;iiii,,,,,.                        
G@8800GGGL;LLLCCCG0GGGCGLi,.            ;tGCf1tffffttt11fttt11ii1i::i1i;;;:.i1,.                    
G@@@@88800;tCLLf1tGGCCCf: .,.   :;i;;:::;1LL1:ittttttttftttt111111ii;;ti;:,;f;:1                    
G@@@@@@@8L:;fLLLiiLG0GGCi..,.  .:;ii1ti;,,1f1:11i11111tffLLftttt1,.:ii:..,::111t                    
G@888888f.,:1ffCGGtiCGGGf..,.   .::;iii:,,;11,;ii111tfffttt1111t:,,:;i;;;;i;1GC1,                   
C8888800f.,:itffLL1:1CCCL:.,,.     ...,. .,,,,,::;;1GGG00GGCLfG1,,,,:;;;;;i1;,:1i.                  
C8888808G,,::1LLftLLt1111;,..   ..    ...:;;:;;;;i10@@@@@@@800f11tLLLftt1iii,. ,i.                  
LG0088880i.,:;1tt1LCCLfftt1, ..  .;tLCCCGGCCLLLLCC0@@@@@@@@@@G;,,,:;11tfLfi:ifftft.                 
fCLLLCCCGf..,;i111fGGCCLCLL;   :tG88888880CLCLLLLL888800@88CGf.,....... :t:,.,:i1LGf,.              
C8GGCCLLLLff;:i1i1fCGGGffLL1,iL0@888888800GCCCCCCCCCGGG000Ctt;,. .,,,,,.:;,.   .. ;0G:.             
G@@@88800GG0f.;1iiifGGGCtfCG088888888880GLfft11tffLCCGCCf1ifL:ii. ......,,.   .:,..f@1..            
C88888888800Ci1ffttfGG008888888@@@88800GCf1i;:;;;;iiiii;:ifGtfLCLft1i;:,,..    .:iiG8i .           .
LGGGGGGG0000088000888888888@@@@@8000GCLft1i;,,,,,,,,,,..,,:;1L;,:;1t1tLftt1i;:;1LG00L;.            ,
LGGGGGGGGGGGG0000088888888888800GGCLftt1ii;:,::::,:;:,,,:;1fCC;   ,..:tLGCftfLG0GGCCCf1,          .,
LGGGGGGGGGGGG00000000000000GGCCCLft11ii;;::,,,,::::;::ifLti1i;....,,.;L0GCLLCCCCCCLLftt1.         .,
fGCCCCCCCCCCGGGCCCCGG000GGGCLLLft1i;;;:::::,::::,,,,,,tCL1;    . .,ifG00GGGGGGCCCLfft11;.         ,,
fCLCLLLLLCCCCCCCCGGGGGCLLffffff1i;:::,:::;::;;i;:;;;ii1t1;;;:.  ,;f00000000GGGCCLfft11;,          ,,
fCCCLCCCCCCCCLffffttt1ii1iii11i;;:::::;;;;:;;;i;;i11tfffffLCf::tCG00000800000GGLftt11i;;:.       .,,
tCLffffttt111iiiiiiiii111tttt1i;;:::;;;;;i:;;;;;iiii11tttttffLCGGG00000800000GCLftt1ii1tt;       .,,
1t111111111i1iii1i1111ttffftt1i;;;;;ii;;;;;;;,.,,......,.:fGGGGG000080000000GGCLfttt1tfft1,     .,,,
1tt111111111111iiiii111ttttt1i;;;iii;;;;:,,,,......  .. :C0GG000000000000000GCLLLffffffft1:     .:,,
1t1111111iiiii;;;iiiiii1tttii;;;;;;::,,..  .,,.........iG0000088888888000000GCCCLCCCCCLft1,     ,,,,
;iiiiiii;;;;:;i1;,,;ii:tCCCLff1,...         .,..... ..;CGGGGGGG0000GGGGGGGGCLLLLLLLCCCCLf1,... .,,,,
", @"
fGCGGCCCt,                                 ......                  .:::,.....          .  . .....   
L000000GCi                                 .......                 .:::,.....         ,;.,.,.,,,.:, 
L000000GGt.                                .,.....                 .::,,.....          . .,..... ,. 
tGG0000GGf,                                 ,,....                 ,:::,.....            ,,.,,,,,,. 
tGG0000GGL;                                 ......                 ,:::,.....           ....... ... 
tCC00000GC1.                                ......                 ,::,,,...                        
1CGGG000GCt,                                .,....                 ,,:,,,,..                        
1fCCG00GCCf:                                .,....                 ,,:,,,,..                        
1fCGG000GCf;                                .,....                 ,::,,,,..                        
tfC000000GCt.                             ..,,....                 ,,:,,,,,.                        
fff000000GGC:                              .,,,,,,,...         .,,,:::,,,,.                         
fLfG0000GGGC;                              .;i;;;;;;;;;::;;;:,,:i;:;ii,,,:,.,                       
fCLC000000GGt.                      ..    .,ii:,;;iiiiiiiiiiiiiiii;;;i1;;;,:f;:.                    
fGffGG00000GC:                     ....,,,.,;;:,::::;;ii11111iiii:,;;;;,,,,ii.t,                    
fGLLCCCCCGCCC1                      ...,,,..:;:,:::;;;;iiii11ii1;..,;;,,,::;LCt.                    
fCCCGGGGCCCCCL:                        .:,....,..,,,iii111iii;f;...,:;;;;ii;it1;.                  .
tLffCGGGGGCC1:..                              ...,,iftL0880f1tf:t1iiiii;;;;.  :i                   ,
tLt1iLCCCCL1. ...                    .,.,;;:,,,,,,iGGG8@@@GLCt,,;11tfffLt::tft1f;                 .,
iLLtitLGGGCL:...,                 :tCGG0080GLLLLLLG0000080GLt: .     ..i1,.,:;itCL,               ,,
;tLCGL;1GGCC1...,.             .iC88888800GCLLLLLCLLCGGGGCf1;.     ....::.    ...LG:              ,,
:itfft;:tCCCf,.,,.          .;fG888888000GCft1ii1ttfffLf111tii1,.    .....    ,. ;0:             .::
,:1ft1tLtt111:,,.     ..,:1LG8@88888800GGLfti;:::::::::,,;ftfLfLLLf1ii;;:,....,;f0L.             ,;:
;1tffffCCLffffLLffLLLLCG0888888@@880GGCLft11i;,,,,:,,,...,;1Lt  ..,,;fttffti1tfft;.              ,::
LGCCCCCCCCGGGG0000008888880888800GGCCLf111ii:,:::,,,,,:i1itLfi      ,;:i:;;;,,:,.               .,:,
fGGGGGGCCCGGGGCGGGG00000000000GCCLLft1ii;;;:,::::,::,:fGL1:..       .,:i::;;.,. :.              .::,
fCCGCCCCCCCCLCCCCCGGGGGG000GGGCLLLf1i;;;::::,::::,,:,,i1i;;i;,      . .;,    ,,,:               ,,,,
tCLLLLLLLLLLLCCCCCCCCCGCCLfffttfftii;;::;;;;:;;i;:;;i1tttfCCCi      ..;;,.   .;,.               ,,:,
tLLLLLCLLLLLCLLLLffffttt111t111t1ii;;;;;;;;;:;;i;i11ttffftti:.      .,:..,   .,                .,,,,
tLLLLLLfffffttttt11111111tfffLfft11i;;;;;;;;;ii;;ii;;::,,.          ..,,:.  .,,,               ,,,:,
tLLfffttttttttttt111111ttffLLLft11iiiiiii;;;;i:....                 ..,,:.  , .,               ,,,,.
tffffftttttttttt11t1111ttttfffft1iiiiiii;;::,. ....                 ..,:,.  ,.,.              .:::,.
1fttfttt111111111iii111iii1111iiiiii;;::,.     ...                  ..,:,.  ,,.               ,,,,,.
1ttt111111111ii;;;i;;:,,.............          ....                ...,,,. .,,                ,,:,,.
i111111iiiiiiii1ttfi                           ....                ...,,,,,,.:.              .,,:,,.
;iiiii;;;;;;tLLLfft;...                         ...                ....,,,, .,               .,,,,,.
", @"
ft:.                                        ......                  ,,,......          .  . .....   
LLi,.                                       .......                .,,,,.....         ,;.,.,.,,,.:, 
LGt,.                                        ......                .,:,,.....          . .,..... ,. 
LGf:.                                        ......                .,,,,.....            ,,.,,,,,,. 
LGL;,.                                       ......                .,,,.....            ....... ... 
L0C1:.                                       ......                .,,,,,...                        
L0Ct:.                                       ......                .,,,,,...                        
LGCLi,.                                      ......                .,,,,,...                        
LGCfi,.                                     .......                .,,,,,,..                        
L0GLt:.                                     ..,,,,..           ....,,,,,,,.                         
L0GGCi,.                                    .:::::::::::,,:,,..,;;:;;;,,,,,.                        
L0GGGt,.                                    ,;;:,:;;;;;;;;;ii;;;;i::;i;;;;,:1:.                     
L0GGGf:.                             ....,,.,::,.,,,:::;iiiii;;;;,:;;;;::,,1;,1                    .
L000GC1,.                            .....,..::,,,,:::::;;iiiiii:..,;:,..::ifti                    ,
L0GGGGL;.                                 .  ......:;;;;;;;;;;1:...,:;;;;i;;ffi,                  .,
fCCCCLL1,....                            .     ...;iifG00Cii;t1;t11111ii;;:...i:                  ,,
LGCCCCL1,,,,,                       .,,ifLti:,,,.;ttL0880Ltt::,,;i11ttff;,;fftf;                  ,,
fGCCLi,..,,:,                    ,tCGG0800GCLLLffLLLCCCGGLti. .       :1,.. .,1Li.               .:,
fGCLt: ...,.                  .;f08880000GLtt11tfLLLCCLf1ii,.       ..,:..     ,C;               .:,
tGGGCt.....                .:tC88888800GGLf1;;;;;iiiii;;ifttff1i;:,,.,...    .:tf.               ,:,
,tCCCL: ...       ....,,:ifC88@888800GCLft1i;:,,,.......:i1fi;i111itt1tt1i;i1tff:               .::,
itLCLLt1111ttfLLLCCCGG0088888888800GCLft11i;:,,,,,,,,.,,;tLL;      ;;;ii1i::,.,,                .::,
LGCCCCCGCGGGGGGGG00000080000800GGCCLf11i;;;:,,:::,,,,1Lf11i:.      ,:i;,:i:  .:,.               ,::,
fCCCGGCCCCCCCCCCCGGGGGGGG0000GCCCCLtii;;:::,,:::,::,,tLt;:,,.        ,:.,.  .: ,,               ,,:,
fCLCCLLLLLLLLLLCCCCCCCGGGGCCCLLLLf1i;;:::::::::;,,:::;ii1fCCt.      .;:.    ,, ,.              .,,,,
tLLLLLLLLLLLLCCCCCLLLLLfft1tt11tt1i;;::;;:;::;ii;;i1tfffLLft;       ,:...    ::.               ,,,,,
tLLLLLLLffLfffffttttt11111tffffft1i;;;;;;;;;:;ii;1t1tt1i;:,         ,,.,,    ,,                ,,,,.
tLLLffLftftttttttt111111ttfLLLLft11i;iiii;;;;ii:;;:,..              .,:;.   ,,,               .,,,,.
tLfffttttttttttttttt111ttfffLLLttiiiiiii;;;;;;...                   .,,:.  .. ,.              ,,,,,.
1ffftfttt1ttttt11111i111tttffft1iiiiii;;;::,.   ...                 .,;,.  ...,               ::,,..
1ttttt1111111111iiiiiii;;;;;;;;;;;;;:::,.       ...                 .,,,.   :,               .,,,,,.
it111111111iiii;;;;:,,..       ...              ...                 .,,,.  ,,                ,,,,,,.
i1iiiiiii;;;;::,..                              ...                 .,..,.:.,.               ,,,,,,.
;iii;;ii11ttti,.                                 ..                 ..,:,:  :.              .,,:,,,.
:;;;;;1LLLLft1:.                                                    ..,:,. ,.               .,,,,...
", @"
                                             .....                 .,,......           .  . .....   
                                             .....                 .,,,.....          ,;.,.,.,,,.:, 
                                             .....                 ,,,,.....           . .,..... ,. 
                                             ......                ,,,.....              ,,.,,,,,,. 
                                             ......               .,,,.,...             ....... ... 
                                             ......               ..,,,,...                         
                                             ......               ..,,.,...                        .
                                             ......               ..,,,,...                        .
                                             ......               ..,,,,,,.                       .,
                                             .,,,,,,......     ,,::,:,,,,.                        .,
                                            .;:,,::::::::;;;::::;::;i::::,.:.                     ,,
                                     .. ....,:,..,,:::::;;;;:;;;::;:;i:;:.;1:;                    ,,
                                     ........::,,,,,,,::;iii;;;:..,;:..,,,i;:i                   .,,
.                                       ... ..,..,,,,,,::::::i:...,:::::;:iCL:.                  .:,
.                                              .,,;tfft::;1i11:;:::;;::::, ,;i,                  ,:,
,.                                   :ii:,,....;;iLGGGf;;:;i1,:tttffff1:,:i, ;,                 .,,,
,,.    ..,.                     .,;1LGGGCLffttfftLLLLLti:    ..   ...1;,..:i:.;.                .,,,
,,....,,,,,                   .1LG000GCCf11i1tffffLf1i;i..          .:,.   ,f:...               ,,,,
.,,,,,,,,,,                 .1C00000GGCLti::;;;;;;;::;itffft1i;::,,,,,,..,;ti. ..               ,,:,
.,,,,,,..                 ,tG888800GCLft1i;,,,....  .,if1,,::::i1itftii111i:..,,.              .::,,
......              ...:1L0888880GCCLt1ii;:,,,.,,,,,,iff1,     :::;:;;:.     .:.               ,:,,,
,,,,,,,,,::;ii1tfLCCGG08888880GGCCLf1ii;;:,,,,,,,:fL11i,.       ,:;,:;:..    ,,                ,:,,,
tLLLLLLLCCCGGGG00000000000000GCCCLt1i;;::,,::::,::1ti;;i1t;      .:... ..   ,,.,              .,::,,
fGGGCCCCCCCCCCCGCGGGCCGG000GGCLLLti;;:::::,::::,::,:;ifLCL1      ::,...     : .,              .,,,,.
fCCCCCLLLCLLLCCCCCCCCGGGCLfLfttftii;::::::::;;i:;i11fffti:       :..,.      .:,.              ,,,,,.
tLLLCLLLLLLLCCCCCLLLfffttttftttt1i;;::;;:;::;ii;1t1t1i:,         .,:,. .     :.              .,,,,..
tLLLLLLfLLLLffftttttttttttfLLLLft1i;;;;;;;;:ii;;ii:,.             .:,       ,,.              .,,,,,.
tLLLfLftfffttftttt11tttttfLLLLLtt1iiiiii;;;:i;,,.                 .:,.     ,..,              ,,,,,..
tLfffffttffttttttttttttfffffLLft1iiiii;;;;:::    ..               ,:.. .   ,.,.              ::,,...
1ffffffttttttttt1111111t11tfft1i;iiii;;;:,.     ...               .,,,..   .:.              .::,,...
1ffttttt11111111iiiiiiii;;;;;;;;;;;::,,.        ...                ,.,.   .,.               .,,,,.,.
1ttt11111111iii;;;;;;:,..                        ...               .,:,..,.,,               ,,,,,,,.
i1111iiiiiii;;;::,..                                                ,:.,, .,.               ,,:,,,,.
;iiiii;;;;;::,.                                                    .,:,,,,,                .,,,,,,,.
:;;;;;;::,.                                                        .,,..                   ,,,,,....
" };
        public static string[] frames = { @"  
______________________________________________________________________________________________________________
||                                                                                                          ||                                                                                                                                                                                                  
||         ____                                     ____                                      ____          ||                                                                                                                                                                                                  
||        |    |                                   |    |                                    |    |         ||
||        |    |                                   |    |                                    |    |         ||
||        |    |                                   |    |                                    |    |         ||                                                                                                                                                                                                  
||        |    |                                   |    |                                    |    |         ||
||        | ## |                                   |    |                                    |    |         ||                                                                                                                                                                                                  
||        | ## |                                   |    |                                    | ## |         ||                                                                                                                                                                                                  
||        | ## |                                   | ## |                                    | ## |         ||
||          ##                                       ##                                        ##           ||
||          ##                                       ##                                        ##           ||                                                                                                                                                                                                  
||          ##                                       ##                                        ##           ||                                                                                                                                                                                                  
||          ##                                       ##                                        ##           ||
||                                                   ##                                        ##           ||
||                                                   ##                                                     ||                                                                                                                                                                                                  
||                                                                                                          ||
||          @@                                                                                              ||                                                                                                                                                                                                  
||          @@                                                                                              ||                                                                                                                                                                                                  
||@@@@@@@@@@@@                                                                                              ||
||                                                                                                          ||
______________________________________________________________________________________________________________

", @"
______________________________________________________________________________________________________________
||                                                                                                          ||                                                                                                                                                                                                  
||         ____                                     ____                                      ____          ||                                                                                                                                                                                                  
||        |    |                                   |    |                                    |    |         ||
||        |    |                                   |    |                                    |    |         ||
||        |    |                                   |    |                                    |    |         ||                                                                                                                                                                                                  
||        |    |                                   |    |                                    |    |         ||
||        | ## |                                   |    |                                    |    |         ||                                                                                                                                                                                                  
||        | ## |                                   |    |                                    | ## |         ||                                                                                                                                                                                                  
||        | ## |                                   | ## |                                    | ## |         ||
||          ##                                       ##                                        ##           ||
||          ##                                       ##                                        ##           ||                                                                                                                                                                                                  
||          ##                                       ##                                        ##           ||                                                                                                                                                                                                  
||          ##                                       ##                                        ##           ||
||          @@                                       ##                                        ##           ||
||          @@                                       ##                                                     ||                                                                                                                                                                                                  
||@@@@@@@@@@@@                                                                                              ||
||                                                                                                          ||                                                                                                                                                                                                  
||                                                                                                          ||                                                                                                                                                                                                  
||                                                                                                          ||
||                                                                                                          ||
______________________________________________________________________________________________________________
", @"
______________________________________________________________________________________________________________
||                                                                                                          ||                                                                                                                                                                                                  
||         ____                                     ____                                      ____          ||                                                                                                                
||        |    |                                   |    |                                    |    |         ||
||        |    |                                   |    |                                    |    |         ||
||        | ## |                                   |    |                                    |    |         ||                                                                                                                                                                                                  
||        | ## |                                   |    |                                    |    |         ||
||        | ## |                                   |    |                                    |    |         ||                                                                                                                                                                                                  
||        | ## |                                   |    |                                    | ## |         ||                                                                                                                                                                                                  
||        | ## |                                   | ## |                                    | ## |         ||
||          ##                                       ##                                        ##           ||
||          ##                                       ##                                        ##           ||                                                                                                                                                                                                  
||          @@                                       ##                                        ##           ||                                                                                                                                                                                                  
||          @@                                       ##                                        ##           ||
||@@@@@@@@@@@@                                       ##                                        ##           ||
||                                                   ##                                                     ||                                                                                                                                                                                                  
||                                                                                                          ||
||                                                                                                          ||                                                                                                                                                                                                  
||                                                                                                          ||                                                                                                                                                                                                  
||                                                                                                          ||
||                                                                                                          ||
______________________________________________________________________________________________________________
", @"
______________________________________________________________________________________________________________
||                                                                                                          ||                                                                                                                                                                                                  
||         ____                                     ____                                      ____          ||                                                                                                                                                                                                  
||        | ## |                                   |    |                                    |    |         ||
||        | ## |                                   |    |                                    |    |         ||
||        | ## |                                   |    |                                    |    |         ||                                                                                                                                                                                                  
||        | ## |                                   |    |                                    |    |         ||
||        | ## |                                   |    |                                    |    |         ||                                                                                                                                                                                                  
||        | ## |                                   |    |                                    | ## |         ||                                                                                                                                                                                                  
||        | ## |                                   | ## |                                    | ## |         ||
||          @@                                       ##                                        ##           ||
||          @@                                       ##                                        ##           ||                                                                                                                                                                                                  
||@@@@@@@@@@@@                                       ##                                        ##           ||                                                                                                                                                                                                  
||                                                   ##                                        ##           ||
||                                                   ##                                        ##           ||
||                                                   ##                                                     ||                                                                                                                                                                                                  
||                                                                                                          ||
||                                                                                                          ||                                                                                                                                                                                                  
||                                                                                                          ||                                                                                                                                                                                                  
||                                                                                                          ||
||                                                                                                          ||
______________________________________________________________________________________________________________
", @"
______________________________________________________________________________________________________________
||                                                                                                          ||                                                                                                                                                                                                  
||         ____                                     ____                                      ____          ||                                                                                                                                                                                                  
||        | ## |                                   |    |                                    |    |         ||
||        | ## |                                   |    |                                    |    |         ||
||        | ## |                                   |    |                                    |    |         ||                                                                                                                                                                                                  
||        | ## |                                   |    |                                    |    |         ||
||        | ## |                                   |    |                                    |    |         ||                                                                                                                                                                                                  
||        | ## |                                   |    |                                    | ## |         ||                                                                                                                                                                                                  
||        | ## |                                   | ## |                                    | ## |         ||
||                                                   ##                                        ##           ||
||                                                   ##                                        ##           ||                                                                                                                                                                                                  
||          @@                                       ##                                        ##           ||                                                                                                                                                                                                  
||          @@                                       ##                                        ##           ||
||@@@@@@@@@@@@                                       ##                                        ##           ||
||                                                   ##                                                     ||                                                                                                                                                                                                  
||                                                                                                          ||
||                                                                                                          ||                                                                                                                                                                                                  
||                                                                                                          ||                                                                                                                                                                                                  
||                                                                                                          ||
||                                                                                                          ||
______________________________________________________________________________________________________________
", @"
______________________________________________________________________________________________________________
||                                                                                                          ||                                                                                                                                                                                                  
||         ____                                     ____                                      ____          ||                                                                                                                                                                                                  
||        | ## |                                   |    |                                    |    |         ||
||        | ## |                                   |    |                                    |    |         ||
||        | ## |                                   |    |                                    |    |         ||                                                                                                                                                                                                  
||        | ## |                                   |    |                                    |    |         ||
||        | ## |                                   |    |                                    |    |         ||                                                                                                                                                                                                  
||        | ## |                                   |    |                                    | ## |         ||                                                                                                                                                                                                  
||        | ## |                                   | ## |                                    | ## |         ||
||                                                   ##                                        ##           ||
||                                                   ##                                        ##           ||                                                                                                                                                                                                  
||                                                   ##                                        ##           ||                                                                                                                                                                                                  
||                                                   ##                                        ##           ||
||                                                   ##                                        ##           ||
||                                                   ##                                                     ||                                                                                                                                                                                                  
||                                @@                                                                        ||
||                                @@                                                                        ||                                                                                                                                                                                                  
||@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@                                                                        ||                                                                                                                                                                                                  
||                                                                                                          ||
||                                                                                                          ||
______________________________________________________________________________________________________________
", @"
______________________________________________________________________________________________________________
||                                                                                                          ||                                                                                                                                                                                                  
||         ____                                     ____                                      ____          ||                                                                                                                                                                                                  
||        | ## |                                   |    |                                    |    |         ||
||        | ## |                                   |    |                                    |    |         ||
||        | ## |                                   |    |                                    |    |         ||                                                                                                                                                                                                  
||        | ## |                                   |    |                                    |    |         ||
||        | ## |                                   |    |                                    |    |         ||                                                                                                                                                                                                  
||        | ## |                                   |    |                                    | ## |         ||                                                                                                                                                                                                  
||        | ## |                                   | ## |                                    | ## |         ||
||                                                   ##                                        ##           ||
||                                                   ##                                        ##           ||                                                                                                                                                                                                  
||                                                   ##                                        ##           ||                                                                                                                                                                                                  
||                                                   ##                                        ##           ||
||                                                   ##                                        ##           ||
||                                                   ##                                                     ||                                                                                                                                                                                                  
||                                                   @@                                                     ||
||                                                   @@                                                     ||                                                                                                                                                                                                  
||@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@                                                     ||                                                                                                                                                                                                  
||                                                                                                          ||
||                                                                                                          ||
______________________________________________________________________________________________________________
", @"
______________________________________________________________________________________________________________
||                                                                                                          ||                                                                                                                                                                                                  
||         ____                                     ____                                      ____          ||                                                                                                                                                                                                  
||        | ## |                                   |    |                                    |    |         ||
||        | ## |                                   |    |                                    |    |         ||
||        | ## |                                   |    |                                    |    |         ||                                                                                                                                                                                                  
||        | ## |                                   | ## |                                    |    |         ||
||        | ## |                                   | ## |                                    |    |         ||                                                                                                                                                                                                  
||        | ## |                                   | ## |                                    | ## |         ||                                                                                                                                                                                                  
||        | ## |                                   | ## |                                    | ## |         ||
||                                                   ##                                        ##           ||
||                                                   ##                                        ##           ||                                                                                                                                                                                                  
||                                                   ##                                        ##           ||                                                                                                                                                                                                  
||                                                   @@                                        ##           ||
||                                                   @@                                        ##           ||
||                                                   @@                                                     ||                                                                                                                                                                                                  
||@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@                                                     ||
||                                                                                                          ||                                                                                                                                                                                                  
||                                                                                                          ||                                                                                                                                                                                                  
||                                                                                                          ||
||                                                                                                          ||
______________________________________________________________________________________________________________
", @"
______________________________________________________________________________________________________________
||                                                                                                          ||                                                                                                                                                                                                  
||         ____                                     ____                                      ____          ||                                                                                                                                                                                                  
||        | ## |                                   | ## |                                    |    |         ||
||        | ## |                                   | ## |                                    |    |         ||
||        | ## |                                   | ## |                                    |    |         ||                                                                                                                                                                                                  
||        | ## |                                   | ## |                                    |    |         ||
||        | ## |                                   | ## |                                    |    |         ||                                                                                                                                                                                                  
||        | ## |                                   | ## |                                    | ## |         ||                                                                                                                                                                                                  
||        | ## |                                   | ## |                                    | ## |         ||
||                                                   @@                                        ##           ||
||                                                   @@                                        ##           ||                                                                                                                                                                                                  
||@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@                                        ##           ||                                                                                                                                                                                                  
||                                                                                             ##           ||
||                                                                                             ##           ||
||                                                                                                          ||                                                                                                                                                                                                  
||                                                                                                          ||
||                                                                                                          ||                                                                                                                                                                                                  
||                                                                                                          ||                                                                                                                                                                                                  
||                                                                                                          ||
||                                                                                                          ||
______________________________________________________________________________________________________________
", @"
______________________________________________________________________________________________________________
||                                                                                                          ||                                                                                                                                                                                                  
||         ____                                     ____                                      ____          ||                                                                                                                                                                                                  
||        | ## |                                   | ## |                                    |    |         ||
||        | ## |                                   | ## |                                    |    |         ||
||        | ## |                                   | ## |                                    |    |         ||                                                                                                                                                                                                  
||        | ## |                                   | ## |                                    |    |         ||
||        | ## |                                   | ## |                                    |    |         ||                                                                                                                                                                                                  
||        | ## |                                   | ## |                                    | ## |         ||                                                                                                                                                                                                  
||        | ## |                                   | ## |                                    | ## |         ||
||                                                                                             ##           ||
||                                                                                             ##           ||                                                                                                                                                                                                  
||                                                                                             ##           ||                                                                                                                                                                                                  
||                                                              @@                             ##           ||
||                                                              @@                             ##           ||
||@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@                                          ||                                                                                                                                                                                                  
||                                                                                                          ||
||                                                                                                          ||                                                                                                                                                                                                  
||                                                                                                          ||                                                                                                                                                                                                  
||                                                                                                          ||
||                                                                                                          ||
______________________________________________________________________________________________________________
", @"
______________________________________________________________________________________________________________
||                                                                                                          ||                                                                                                                                                                                                  
||         ____                                     ____                                      ____          ||                                                                                                                                                                                                  
||        | ## |                                   | ## |                                    |    |         ||
||        | ## |                                   | ## |                                    |    |         ||
||        | ## |                                   | ## |                                    |    |         ||                                                                                                                                                                                                  
||        | ## |                                   | ## |                                    |    |         ||
||        | ## |                                   | ## |                                    |    |         ||                                                                                                                                                                                                  
||        | ## |                                   | ## |                                    | ## |         ||                                                                                                                                                                                                  
||        | ## |                                   | ## |                                    | ## |         ||
||                                                                                             ##           ||
||                                                                                             ##           ||                                                                                                                                                                                                  
||                                                                                             ##           ||                                                                                                                                                                                                  
||                                                                                             ##           ||
||                                                                                             ##           ||
||                                                                                                          ||                                                                                                                                                                                                  
||                                                                                             @@           ||
||                                                                                             @@           ||                                                                                                                                                                                                  
||@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@           ||                                                                                                                                                                                                  
||                                                                                                          ||
||                                                                                                          ||
______________________________________________________________________________________________________________
", @"
______________________________________________________________________________________________________________
||                                                                                                          ||                                                                                                                                                                                                  
||         ____                                     ____                                      ____          ||                                                                                                                                                                                                  
||        | ## |                                   | ## |                                    |    |         ||
||        | ## |                                   | ## |                                    |    |         ||
||        | ## |                                   | ## |                                    |    |         ||                                                                                                                                                                                                  
||        | ## |                                   | ## |                                    |    |         ||
||        | ## |                                   | ## |                                    |    |         ||                                                                                                                                                                                                  
||        | ## |                                   | ## |                                    | ## |         ||                                                                                                                                                                                                  
||        | ## |                                   | ## |                                    | ## |         ||
||                                                                                             ##           ||
||                                                                                             ##           ||                                                                                                                                                                                                  
||                                                                                             ##           ||                                                                                                                                                                                                  
||                                                                                             @@           ||
||                                                                                             @@           ||
||@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@           ||                                                                                                                                                                                                  
||                                                                                                          ||
||                                                                                                          ||                                                                                                                                                                                                  
||                                                                                                          ||                                                                                                                                                                                                  
||                                                                                                          ||
||                                                                                                          ||
______________________________________________________________________________________________________________
", @"
______________________________________________________________________________________________________________
||                                                                                                          ||                                                                                                                                                                                                  
||         ____                                     ____                                      ____          ||                                                                                                                                                                                                  
||        | ## |                                   | ## |                                    |    |         ||
||        | ## |                                   | ## |                                    | ## |         ||
||        | ## |                                   | ## |                                    | ## |         ||                                                                                                                                                                                                  
||        | ## |                                   | ## |                                    | ## |         ||
||        | ## |                                   | ## |                                    | ## |         ||                                                                                                                                                                                                  
||        | ## |                                   | ## |                                    | ## |         ||                                                                                                                                                                                                  
||        | ## |                                   | ## |                                    | ## |         ||
||                                                                                             ##           ||
||                                                                                             @@           ||                                                                                                                                                                                                  
||                                                                                             @@           ||                                                                                                                                                                                                  
||@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@           ||
||                                                                                                          ||
||                                                                                                          ||                                                                                                                                                                                                  
||                                                                                                          ||
||                                                                                                          ||                                                                                                                                                                                                  
||                                                                                                          ||                                                                                                                                                                                                  
||                                                                                                          ||
||                                                                                                          ||
______________________________________________________________________________________________________________
", @"
______________________________________________________________________________________________________________
||                                                                                                          ||                                                                                                                                                                                                  
||         ____                                     ____                                      ____          ||                                                                                                                                                                                                  
||        | ## |                                   | ## |                                    | ## |         ||
||        | ## |                                   | ## |                                    | ## |         ||
||        | ## |                                   | ## |                                    | ## |         ||                                                                                                                                                                                                  
||        | ## |                                   | ## |                                    | ## |         ||
||        | ## |                                   | ## |                                    | ## |         ||                                                                                                                                                                                                  
||        | ## |                                   | ## |                                    | ## |         ||                                                                                                                                                                                                  
||        | ## |                                   | ## |                                    | ## |         ||
||                                                                                             @@           ||
||                                                                                             @@           ||                                                                                                                                                                                                  
||@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@           ||                                                                                                                                                                                                  
||                                                                                                          ||
||                                                                                                          ||
||                                                                                                          ||                                                                                                                                                                                                  
||                                                                                                          ||
||                                                                                                          ||                                                                                                                                                                                                  
||                                                                                                          ||                                                                                                                                                                                                  
||                                                                                                          ||
||                                                                                                          ||
______________________________________________________________________________________________________________
" };
        
        public static string[] lockpicking = { @"
...,:ii;,.     .,,..  .,:,. .;;;:,,,:,;:;;,,....,,...,:,:,,,:::::::,,,,,.,,,.,,,,,,,::;:,,,.,,,,,:::
     ,:;ii;:,.. .:,,,...,,,..;;;:,,,:,;:;;:,.....  ,,::,..,;::::;:::,,,,.,;,,,,,,::;:,:;:,,,..,,,:::
...,...,,:;;i;,..,,,:,:,.....;;;;,,,::;:;;:,...  ,.,,,..,:::,,.:;;;;:,:,,,;:,,::;;:,,,,,::;:,,,:,:::
..,,.,:,...,,;;;;:,.,::::,. .;;i;,,:,::;;;:,.  .,,.,..,:::,,,::,:::;;;:,,:i:::ii:,,,,,,,.,::::::,:::
,::,,::,.,...,,:;;;:,.,::,,,.:;i;:,:,::;;;:,....,....,::::,,,:,.,:::,:i;:ii;;;;:,::::,,:,.....,:,,::
:,,::;:,,,,,.,,,,:;;;;,..,,,.;;;;:::,::;;;::,.,.,.,,,:::::::,,,,:::;:,:;:;::;;;;:;;;:,,,,,,,,,,:,,::
,,:::::,,:;ii;;;:::::::;;:;11t1i;:::;:::;;;;;;:;;i11i11i111iii;;;::::::;1i;:::;;;:::;:;;;:::::::,,::
,::;;,::;1ff11tii:::,,,:;;1fLLt1t1;:,,,,,,,,,,,,,,,::::::::::::::::::,::;::::::::;i;i1iiiii,.,::,,::
:::::,::;it1:it;1;::,:,,.:;:i1iit;;:.,,,,,,,,,:,,,::::;:;:::;;:;:::;;:::::::::::,;;iii,i;ii,,::,,,:,
::,,,,;;;ii;:::;:,,::;;:,,;;::i;::;,,,,,,:,::::::,:::;;;::;::::::::::::::;;;;;:::,,:::::;;i::::,,,..
:::::,::i1i:.::,,::;::;i;:ii;,:i;:;i;::;1ii;;;::::::::::::::::::;::;:;;;i11iii;;;;:,,:,:;;i;::,,..,,
,;;,::::;1i:,,:::::i:;1;i:ii;,.,:::;;;;;i1i;::::,,,,,,::::::::::::::;;;;i1111iii;;;:::,:;;;;,,,,,,::
.:;:,::,;1i:.,:::;:iiiiii;11i,.,,,:;::;::;::,..,,:iii1fffft1i;;ii;:::::;ii11tt11ii;;::,,:;i,,:::,,::
,,,:i;:,;ti:.,;i;;;i;1i1;:11i,.,:;1tfi::::;:,:i11fLLCCLLCCCLt1111i;i;::::;ii111111;;::,,:;i::::::,:,
,::.:;;:;fi:,:::;;;1;iii;:11;,,:;i111i;:,,:,,:iLG0000000GG00Ctttiiiiiii;;::i1i1i1iii::,,:ii:,,,,,...
..::,..:it1;,,;;;;:1:;i;:;fti:,,:iii;;:.,i1i;:.,1G00CLLftttffttftffttiiii1;;1iiiii;;::,:;;i:,.....,,
,...::. ;t1;,:;::;;i;i::,iLLi:,,;i;;;:.:1tffCGfi,,i1ii;;;;;;;;ii1ttftt11111i;i;;iii;::,:;i1,   .,.,,
.,,..,,.;fti,:;::;;i:,,;,;CL1:,:;i;:,.;1tfLG88Gfi:,,:;ii;;;;;iiii;iitLfft1111i;iiii;;;,;ii1...,,:,,,
..,,..,.iLti:,i;;;:;,;i,.;CL1:,:;;;:,i1tLL080Li;i111i::;;iii111t11;;itffftf1ii:;i;i;;:,;i1t,......,,
;;;;iii;1fi;:::,:;:i;;:,.;LL1:::;;:,:ttfLG80Lii1tffLLti;::;1ttttft1i;;tLtffti;:::;i;;:,;i1f;::::::::
;;iiiii;1fti:,ii;;,;:;::,;LLi:,:;;:.;tffL00Lii1tfLLLLttt1i,,:,;ttft1i;:tfftft;;::;;;;:,;1tfiiiiiiiii
iiiii11iit1;,,::,,,;:,.:,;Lfi:,:;;,,i1tfCGGt;111fffLt1t11i.    1ttftti:iLffffi;:,:::;:,;1ffi;ii;;;;;
iiiiiiiii11i,,::,,,;:;;,.;LLi:::;;,,;1ttLCCt;i1t1ttttt1;:  ,,,;ftCLff1iiLffLf1i:,,::::,i1tt1iiiiiiii
iiii;iiii1i:.,;;:,,;:;:,.;CCt:::;:,,;i1ttLLt;i11t1tt1;::.:tfffffCGCLftiiLfft1ii:.,::::,:i1tiiiiiiiii
;;;;;;iiii;,.,,.,,,;::,;,;CCi,,,;:,,:;i11LCt;i111LLt;1i;1ft11tfLLLLLf1;1Cfftt1;:,:::::,:;itiiiiiiiii
.....,,,:i:,..;;::,;:;,:,;ft;,,.:::,,:;;itff1;it1Lt1tt111iiii111tttt1iiCLft1ii:,,::;;:,:;;1iii;;;;;;
     .. :1;:..,,,,,:,::::;t1;,,.:::,,::;;i1ttiiii11ti11iii;;:;iii11i;;fLtt1i;:,,:::;;:,:;11i;iii;;ii
.,......:i;:..,,,,.:.,;::;t1;,,.::::,.,::;i1tt11fft1111ii;;;;;;ii;;;itt11iii:,.,,,:::,,:;i1;::::::::
:::::::::i;:..::,,.:.,:;::1i;,:.,,,,,..,::;i1ffCL1iiiii;;;;;;;;;;;i1111ii;;:,.,,,,::::,:;ii1iiiiiiii
.,,,,,:::;;,..,...,:,,,:::ii;,,,,,,,,,..,,:;tfft1ttt1ii;;;;;iiii11iii;;;;:,..,,,::::::,:;ii,,::::::;
   .. ..:i;,..;;::,;.:i,,,ii:,,.,:,:,,.  .;tt1titftffffLfLffLft1ii;;;:::,.,,,,,:::::::,,;ii..... .. 
.,,.  ,.:i;,.,,.,,:i::::,,i;:,,.,:::::::i1tt1i;;iiii11tttt1111i;;;;:,,,...,,:::;i;;:::,,;11,......  
,,..,,,.,;:,..:::::i;i;:.,;::..,,,,;1tfLft1i;;::;::::;;;;iii;;::,,.......,,,:;iii;::::,:;;i. .      
,,:::. .:;;...::,,,;:;;:,,i;:,,.,:1LLLft11ii:,,..,,,:::,,,,,,............,,::;i;;::,,:,,;i;,......  
,:;:,.::;;:...,,,..:.;i:,,;;:..;fLfft1i;;;;::,.........................,,,::;;;;:,,,::,,:;i:::,,,,,.
::,,;::;:;:,.,:::,,:,,:;,.::,,tft1tffti;::::,,........................,,,:::;;;::::;::,,,:;:::::::::
,,::;::;;i;::::::,,;,:,,..:,;1tttfLft1;:::,,,,,.,,,,,,..........,...,,,,,:,:::::;:,::::,,;;:,,,,,,,,
,:;;;:::;i;;;1t;;,,;,,,,..:1fLLLLft111;,:,,,,,,,,,,,,,,,,,,..,,,,,,,:::::::,:::::,:;i1;;:;i,.....,,,
:;;;:::;;iii::;;;,.,...,.,fCLLfftt1i;;;,...,,,,...,,:,,,,,,,,,,,:,,,,,,,,,,:::,,,,::::,;;;;.        
.:;;;;:;itt11iiii;::;:,,:fLfft111i;::::,,,,,,,,,,,,,,,,,,..,,,,,,....,,,,::::::::::;;;;;iii.......  
,,::;::;:ii11iiiii;;:::itffttfL1;;;:::;;;;;::::::;;;;i;;:::::::::::,,:,::::;::;;;::;ii;;:;,   .,,...
,:::;;:;;;::;::;,,,,.:t11tLtffft::;:::;;;;::.  .,,,,,,...,::;;::;:,...........:::,. .,::,,,,   .,,,,
,,ii;iii;:::;;:i;,,:,:ifttt11iii:,,;::;;;;;:,.,,,,,...,,:::,:;;:,,,,,,,,,,,,. .:;:;:,,,,:::::    .,,
;;:;1ii1ii;:ii,:;::,..,:1;::::,,,:;;::;;;;;,,....  .,::::,...,;;,,:,,,,,,,,,....:;;;:::,.,:::..,.  .
,;i:;ii;iti;;:,i;,1;,::,,,.,,,;1111i;;;;;;;,,   ..,,,:,::,,,:::,;;:,::,:;:,:,.,,.:i;;:;;,..,:..::,. 
:,;;::;;:ii;::,i;;11;;,..,,,..1LLLf1;;;iiii:,  .,,,,,:::,,,,,,,:,;;::;:,i:::,.,:,,i;:,:;;:,....,::,,
", @"
.... .:ii;,.  ..,,.   .,:,. .;;;:,,,:,;:;;,,....,,...,:,:,,,:::::::,,,,,.,,,.,,,,,,,::;:,,,.,,,,,:::
     . .:;ii:,. .:,,,...,,,..;;;:,,,:,;:;;:,.....  ,,::,..,;::::;:::,,,,.,;,,,,,,::;:,:;:,,,..,,,:::
...,.,,,..,,:i;,,.,,:,:,.....;;;;,,,::;:;;:,...  ,.,,,..,:::,,.:;;;;:,:,,,;:,,::;;:,,,,,::;:,,,:,:::
..,,.,:,,,....:;;;,.,,:::,. .;;i;,,:,::;;;:,.  .,,.,..,:::,,,::,:::;;;:,,:i:::ii:,,,,,,,.,::::::,:::
,::,,::,.,.....,::;;:,,,:,,..:;i;:,:,::;;;:,....,....,::::,,,:,.,:::,:i;:ii;;;;:,::::,,:,.....,:,,::
:,,::;:,,,,,.,,,,,,:;;:,.,,,.;;;;:::,::;;;::,.,.,.,,,:::::::,,,,:::;:,:;:;::;;;;:;;;:,,,,,,,,,,:,,::
,,:::::,,:;ii;;;::::::::;;;i1t1i;:::;:::;;;;;;:;;i11i11i111iii;;;::::::;1i;:::;;;:::;:;;;:::::::,,::
,::;;,::;1ff11tii:::,:,,,:i1tL1111;:,,,,,,,,,,,,,,,::::::::::::::::::,::;::::::::;i;i1iiiii,.,::,,::
:::::,::;it1:it;1;::,,,,.,;::;;;t;;:.,,,,,,,,,:,,,::::;:;:::;;:;:::;;:::::::::::,;;iii,i;ii,,::,,,:,
::,,,,;;;ii;:::;:,,::;;:,,ii;:;i::;::,,,,,,::::::,:::;;;::;::::::::::::::;;;;;:::,,:::::;;i::::,,,..
:::::,::i1i:.::,,::;::;i;:iii,,:;::ii;;;1iii;;::::::::::::::::::;::;:;;;i11iii;;;;:,,:,:;;i;::,,..,,
,;;,::::;1i:,,:::::i:;1;i:ii;,..:,,:::;;;1i;::::,,,,,,::::::::::::::;;;;i1111iii;;;:::,:;;;;,,,,,,::
.:;:,::,;1i:.,:::;:iiiiii;11i,.,,,:;i::;::::,...,:iii1fffft1i;;ii;:::::;ii11tt11ii;;::,,:;i,,:::,,::
,,,:i;:,;ti:.,;i;;;1;1i1;:11i,.,:;1tLt;:::::,,ittfLLCCLLCCCLt1111i;i;::::;ii111111;;::,,:;i::::::,:,
,::.:;;:;fi:,:::;;;1;iii;:11;,,:;i111i;:.,::,,:tG0000000GG00Ctttiiiiiii;;::i1i1i1iii::,,:ii:,,,,,...
..::,..:it1;,,;;;;:1:;i;:;fti:,,:iiii;:.,i11i;,.;L00CLLftttffttftffttiiii1;;1iiiii;;::,:;;i:,.....,,
,...::. ;t1;,:;::;;i;i::,iLLi:,,;i;;;:.:1tffG0Ct:.:iii;;;;;;;;ii1ttfft11111i;i;;iii;::,:;i1,   .,.,,
.,,..,,.;fti,:;::;;i:,,;,;CL1:,:;i;:,.;1tfLG80Gfi;:,::;i;;;;;iiii;;itLfft1111i;iiii;;;,;ii1...,,:,,,
..,,..,.iLti:,i;;;:;,;i,.;CL1:,:;;;:,i1tLL080Li;ii11i;::;iii111t1i;;itffftf1ii:;i;i;;:,;i1t,......,,
;;;;iii;1fi;:::,:;:i;;:,.;LL1:::;;:,:ttfLG80Lii1tffLLf1;::;1ttttft1i;;tLtffti;:::;i;;:,;i1f;::::::::
;;iiiii;1fti:,ii;;,;:;::,;LLi:,:;;:.;tffL00Li;1tfLLCLttt1i,,,,;ttft1i;:tfftft;;::;;;;:,;1tfiiiiiiiii
iiiii11iit1;,,::,,,;:,.:,;Lfi:,:;;,,i1tfCGGt;11tffLLt1t11i  .  1ttftti;iLffffi;:,:::;:,;1ffi;ii;;;;;
iiiiiiiii11i,,::,,,;:;;,.;LLi:::;;,,;1ttLCCt;i111ttttt1;:  ,,,iftCLff1iiLffLf1i:,,::::,i1tt1iiiiiiii
iiii;iiii1i:.,;;:,,;:;:,.;CCt:::;:,,;i1ttLLt;i11t1tt1;::.,tfffffCGCLftiiLfft1ii:.,::::,:i1tiiiiiiiii
;;;;;;iiii;,.,,.,,,;::,;,;CCi,,,;:,,:;i11LCt;i111LLt:ii;ift11tffLLLft1;tCfftt1;:,:::::,:;itiiiiiiiii
.....,,,:i:,..;;::,;:;,:,;ft;,,.:::,,:;;itff1iit1Lf1tt111iiii1111ttt1iiCLft1ii:,,::;;:,:;;1iii;;;;;;
     .. :1;:..,,,,,:,::::;t1;,,.:::,,::;;i1ttiiii11t111iii;;:;;ii11i;;fftt1i;:,,:::;;:,:;11i;iii;;ii
.,......:i;:..,,,,.:.,;::;t1;,,.::::,.,::;i1tt1itfft1111i;;;;;;ii;;;itt11iii:,.,,,:::,,:;i1;::::::::
:::::::::i;:..::,,.:.,:;::1i;,:.,,,,,..,::;itffLCtiiiii;;;;;;;;;;;i1111ii;;:,.,,,,::::,:;ii1iiiiiiii
.,,,,,:::;;,..,...,:,,,:::ii;,,,,,,,,,..,,::1fff1ttt1iii;;;;iiii11iii;;;;:,..,,,::::::,:;ii,,::::::;
   .. ..:i;,..;;::,;.:i,,,ii:,,.,:,,,,.  .:1ttt11ftffffLfLffLft1ii;;;:::,.,,,,,:::::::,,;ii..... .. 
.,,.  ,.:i;,.,,.,,:i::::,,i;:,,.,:::;:,,:;1t1ii;iiii11tttt1111i;;;;:,,,...,,:::;i;;:::,,;11,......  
,,..,,,.,;:,..:::::i;i;:.,;::,..,,::;itffftiii;:;::::;;;;iii;;::,,.......,,,:;iii;::::,:;;i. .      
,,:::. .:;;...::,,,;:;;:,,;;:,,...:tLLLft11i;,,,.,,,:::,,,,,,............,,::;i;;::,,:,,;i;,......  
,:;:,.::;;:...,,,..:.;i:,,;;:,..ifLLf11iiii:::,........................,,,::;;;;:,,,::,,:;i:::,,,,,.
::,,;::;:;:,.,:::,,:,,::,.:::.:fLftttt1;;:::,,........................,,,:::;;;::::;::,,,:;:::::::::
,,::;::;;i;::::::,,;,:,,..::,:tt1tfLf1i;:::,,,,.,,,,,,..........,...,,,,,:,:::::;:,::::,,;;:,,,,,,,,
,:;;;:::;i;;;1t;;,,;,,,,.,::1tffLffftti:::,,,,,,,,,,,,,,,,,..,,,,,,,:::::::,:::::,:;i1;;:;i,.....,,,
:;;;:::;;iii::;;;,.,...,..:fLLLLLft1iii:,,..,,,...,,:,,,,,,,,,,,:,,,,,,,,,,:::,,,,::::,;;;;.        
.:;;;;:;itt11iii;;::;:::::fCLfttt1i;;;;:,,,,,,,,,,,,,,,,,..,,,,,,....,,,,::::::::::;;;;;iii.......  
,,::;::;:ii11iiiii;;:;::ifftttt1ii;::::;;;;;:::::;;;;i;;:::::::::::,,:,::::;::;;;::;ii;;:;,   .,,...
,:::;;:;;;::;::;,,,,..:ittLffLLL;:;;,:;;;;::.  .,,,,,,...,::;;::;:,...........:::,. .,::,,,,   .,,,,
,,ii;iii;:::;;:i;,,:,,1tttft1t1ti:,;::;;;;;:,.,,,,,...,,:::,:;;:,,,,,,,,,,,,. .:;:;:,,,,:::::    .,,
;;:;1ii1ii;:ii,:;::,.,:;ttiii;;:,,::::;;;;;,,....  .,::::,...,;;,,:,,,,,,,,,....:;;;:::,.,:::..,.  .
,;i:;ii;iti;;:,i;,1;,::,,;,,,:::;11i;;;;;;;,,   ..,,,:,::,,,:::,;;:,::,:;:,:,.,,.:i;;:;;,..,:..::,. 
:,;;::;;:ii;::,i;;11;;,..,,,,.iLLLf1;;;iiii:,  .,,,,,:::,,,,,,,:,;;::;:,i:::,.,:,,i;:,:;;:,....,::,,
", @"
....:;ii:.    ..,,..  .,:,. .;;;:,,,:,;:;;,,....,,...,:,:,,,:::::::,,,,,.,,,.,,,,,,,::;:,,,.,,,,,:::
     .,;ii;:,.. .,,.,...,,,..;;;:,,,:,;:;;:,.....  ,,::,..,;::::;:::,,,,.,;,,,,,,::;:,:;:,,,..,,,:::
...,.,.,,:;;;;:..,,,:,:,.....;;;;,,,::;:;;:,...  ,.,,,..,:::,,.:;;;;:,:,,,;:,,::;;:,,,,,::;:,,,:,:::
..,,.,:,....,:;;;:,.,,:::,. .;;i;,,:,::;;;:,.  .,,.,..,:::,,,::,:::;;;:,,:i:::ii:,,,,,,,.,::::::,:::
,::,,::,.,....,:;;;:,.,::,,,.:;i;:,:,::;;;:,....,....,::::,,,:,.,:::,:i;:ii;;;;:,::::,,:,.....,:,,::
:,,::;:,,,,,.,,,,,:;;;,..,,,.;;;;:::,::;;;::,.,.,.,,,:::::::,,,,:::;:,:;:;::;;;;:;;;:,,,,,,,,,,:,,::
,,:::::,,:;ii;;;:::::::;;:;11t1i;:::;:::;;;;;;:;;i11i11i111iii;;;::::::;1i;:::;;;:::;:;;;:::::::,,::
,::;;,::;1ff11tii:::,,,:;;1tLLt1t1;:,,,,,,,,,,,,,,,::::::::::::::::::,::;::::::::;i;i1iiiii,.,::,,::
:::::,::;1t1:it;1;::,:,,.,;:;1iit;;:.,,,,,,,,,:,,,::::;:;:::;;:;:::;;:::::::::::,;;iii,i;ii,,::,,,:,
::,,,,;;;ii;:::;:,,::;;:,,;;::i;::;,,,,,,:,::::::,:::;;;::;::::::::::::::;;;;;:::,,:::::;;i::::,,,..
:::::,::i1i:.::,,::;::;i;:ii;,:i;:;i;;:;1ii;;;::::::::::::::::::;::;:;;;i11iii;;;;:,,:,:;;i;::,,..,,
,;;,::::;1i:,,:::::i:;1;i:ii;,.,::,;;;;;i1i;::::,,,,,,::::::::::::::;;;;i1111iii;;;:::,:;;;;,,,,,,::
.:;:,::,;1i:.,:::;:iiiiii;11i,.,,,:;:::::;::,...,:iii1fffft1i;;ii;:::::;ii11tt11ii;;::,,:;i,,:::,,::
,,,:i;:,;ti:.,;i;;;i;1i1;:11i,.,:;1tf1;:::::,:i11fLLCCLLCCCLt1111i;i;::::;ii111111;;::,,:;i::::::,:,
,::.:;;:;fi:,:::;;;1;iii;:11;,,:;i111i;:,,::,:iLG0000000GG00Ctttiiiiiii;;::i1i1i1iii::,,:ii:,,,,,...
..::,..:it1;,,;;;;:1:;i;:;fti:,,:iii;;:.,i1i;:.,1C00CCLftttffttftffttiiii1;;1iiiii;;::,:;;i:,.....,,
,...::. ;t1;,:;::;;i;i::,iLLi:,,;i;;;:.:1tffCGLi,,i1ii;;;;;;;;ii1ttfft11111i;i;;iii;::,:;i1,   .,.,,
.,,..,,.;fti,:;::;;i:,,;,;CL1:,:;i;:,.;1tfLG80Gfi:,,::;i;;;;;iiii;iitLfft1111i;iiii;;;,;ii1...,,:,,,
..,,..,.iLti:,i;;;:;,;i,.;CL1:,:;;;:,i1tLL080Li;ii11i:::;iii111t11;;itLfftf1ii:;i;i;;:,;i1t,......,,
;;;;iii;1fi;:::,:;:i;;:,.;LL1:::;;:,:ttfLG80Lii1tffLLti;::;1ttttft1i;;tLtffti;:::;i;;:,;i1f;::::::::
;;iiiii;1fti:,ii;;,;:;::,;LLi:,:;;:.;tffL00Li;1tfLLCLttt1i,,,,;ttft1i;:tfftft;;::;;;;:,;1tfiiiiiiiii
iiiii11iit1;,,::,,,;:,.:,;Lfi:,:;;,,i1tfCGGt;111fffLt1111i  .  1ttft1;:iLffffi;:,:::;:,;1ffi;ii;;;;;
iiiiiiiii11i,,::,,,;:;;,.;LLi:::;;,,;1ttLCC1;i111ttttt1;:  ,,,iftCLff1iiLffLf1i:,,::::,i1tt1iiiiiiii
iiii;iiii1i:.,;;:,,;:;:,.;CCt:::;:,,;i1ttLLt;i11t1tt1;::.,tfffffCGCLftiiLfft1ii:.,::::,:i1tiiiiiiiii
;;;;;;iiii;,.,,.,,,;::,;,;CCi,,,;:,,:;i11LCt;i1t1LLt:ii;ift11tffLLLft1;tCfftt1;:,:::::,:;itiiiiiiiii
.....,,,:i:,..;;::,;:;,:,;ft;,,.:::,,:;;itff1;it1Lf1tt111iiii1111ttt1iiCLft1ii:,,::;;:,:;;1iii;;;;;;
     .. :1;:..,,,,,:,::::;t1;,,.:::,,::;;i1ttiiii11ti11iii;;:;;ii11i;;fftt1i;:,,:::;;:,:;11i;iii;;ii
.,......:i;:..,,,,.:.,;::;t1;,,.::::,.,::;i1tt1itfft1111i;;;;;iii;;;itt11iii:,.,,,:::,,:;i1;::::::::
:::::::::i;:..::,,.:.,:;::1i;,:.,,,,,..,::;itffLCtiiiii;;;;;;;;;;;i1111ii;;:,.,,,,::::,:;ii1iiiiiiii
.,,,,,:::;;,..,...,:,,,:::ii;,,,,,,,,,..,,::1fff1ttt1iii;;;;iiii11iii;;;;:,..,,,::::::,:;ii,,::::::;
   .. ..:i;,..;;::,;.:i,,,ii:,,.,:,,,,.  .:1ttt11ftffffLfLffLft1ii;;;:::,.,,,,,:::::::,,;ii..... .. 
.,,.  ,.:i;,.,,.,,:i::::,,i;:,,.,:::;:,,,;1t1ii;iiii11tttt1111i;;;;:,,,...,,:::;i;;:::,,;11,......  
,,..,,,.,;:,..:::::i;i;:.,;::...,,::;i1ffftiii;:;;:::;;;;iii;;::,,.......,,,:;iii;::::,:;;i. .      
,,:::. .:;;...::,,,;:;;:,,;;:,,..,:tLLLft11i;,,,.,,,:::,,,,,,............,,::;i;;::,,:,,;i;,......  
,:;:,.::;;:...,,,..:.;i:,,;;:,..;fLLf11iiii:::,........................,,,::;;;;:,,,::,,:;i:::,,,,,.
::,,;::;:;:,.,:::,,:,,:;,.:::.:tLftttt1;;:::,,........................,,,:::;;;::::;::,,,:;:::::::::
,,::;::;;i;::::::,,;,:,,..,:,:tt1tfffti;:::,,,,.,,,,,,..........,...,,,,,:,:::::;:,::::,,;;:,,,,,,,,
,:;;;:::;i;;;1t;;,,;,,,,.,::1tffLffftti:::,,,,,,,,,,,,,,,,,..,,,,,,,:::::::,:::::,:;i1;;:;i,.....,,,
:;;;:::;;iii::;;;,.,...,..:fLfLLLtt1iii:,,..,,,...,,:,,,,,,,,,,,:,,,,,,,,,,:::,,,,::::,;;;;.        
.:;;;;:;itt11iiii;::;:::::fCLfttt1i;;;;;,,,,,,,,,,,,,,,,,..,,,,,,....,,,,::::::::::;;;;;iii.......  
,,::;::;:ii11iiiii;;:;::;fLtttt1ii;::::;;;;;:::::;;;;i;;:::::::::::,,:,::::;::;;;::;ii;;:;,   .,,...
,:::;;:;;;::;::;,,,,..,ittfffLLL;:;;,:;;;;::.  .,,,,,,...,::;;::;:,...........:::,. .,::,,,,   .,,,,
,,ii;iii;:::;;:i;,,:,,1tttft1t1ti,,:::;;;;;:,.,,,,,...,,:::,:;;:,,,,,,,,,,,,. .:;:;:,,,,:::::    .,,
;;:;1ii1ii;:ii,:;::,.,:;ttiii;;:,,::::;;;;;,,....  .,::::,...,;;,,:,,,,,,,,,....:;;;:::,.,:::..,.  .
,;i:;ii;iti;;:,i;,1;,::,,i,,,:::;11i;;;;;;;,,   ..,,,:,::,,,:::,;;:,::,:;:,:,.,,.:i;;:;;,..,:..::,. 
:,;;::;;:ii;::,i;;11;;,..,:,,.ifLLf1;;;iiii:,  .,,,,,:::,,,,,,,:,;;::;:,i:::,.,:,,i;:,:;;:,....,::,,
", @"
.... .:ii;,.  ..,,.   .,:,. .;;;:,,,:,;:;;,,....,,...,:,:,,,:::::::,,,,,.,,,.,,,,,,,::;:,,,.,,,,,:::
     . .:;ii:,. .:,,,...,,,..;;;:,,,:,;:;;:,.....  ,,::,..,;::::;:::,,,,.,;,,,,,,::;:,:;:,,,..,,,:::
...,.,,,..,,:i;,,.,,:,:,.....;;;;,,,::;:;;:,...  ,.,,,..,:::,,.:;;;;:,:,,,;:,,::;;:,,,,,::;:,,,:,:::
..,,.,:,,,....:;;;,.,,:::,. .;;i;,,:,::;;;:,.  .,,.,..,:::,,,::,:::;;;:,,:i:::ii:,,,,,,,.,::::::,:::
,::,,::,.,.....,::;;:,,,:,,..:;i;:,:,::;;;:,....,....,::::,,,:,.,:::,:i;:ii;;;;:,::::,,:,.....,:,,::
:,,::;:,,,,,.,,,,,,:;;:,.,,,.;;;;:::,::;;;::,.,.,.,,,:::::::,,,,:::;:,:;:;::;;;;:;;;:,,,,,,,,,,:,,::
,,:::::,,:;ii;;;::::::::;;;i1t1i;:::;:::;;;;;;:;;i11i11i111iii;;;::::::;1i;:::;;;:::;:;;;:::::::,,::
,::;;,::;1ff11tii:::,:,,,:i1tL1111;:,,,,,,,,,,,,,,,::::::::::::::::::,::;::::::::;i;i1iiiii,.,::,,::
:::::,::;it1:it;1;::,,,,.,;::;;;t;;:.,,,,,,,,,:,,,::::;:;:::;;:;:::;;:::::::::::,;;iii,i;ii,,::,,,:,
::,,,,;;;ii;:::;:,,::;;:,,ii;:;i::;::,,,,,,::::::,:::;;;::;::::::::::::::;;;;;:::,,:::::;;i::::,,,..
:::::,::i1i:.::,,::;::;i;:iii,,:;::ii;;;1iii;;::::::::::::::::::;::;:;;;i11iii;;;;:,,:,:;;i;::,,..,,
,;;,::::;1i:,,:::::i:;1;i:ii;,..:,,:::;;;1i;::::,,,,,,::::::::::::::;;;;i1111iii;;;:::,:;;;;,,,,,,::
.:;:,::,;1i:.,:::;:iiiiii;11i,.,,,:;i::;::::,...,:iii1fffft1i;;ii;:::::;ii11tt11ii;;::,,:;i,,:::,,::
,,,:i;:,;ti:.,;i;;;1;1i1;:11i,.,:;1tLt;:::::,,ittfLLCCLLCCCLt1111i;i;::::;ii111111;;::,,:;i::::::,:,
,::.:;;:;fi:,:::;;;1;iii;:11;,,:;i111i;:.,::,,:tG0000000GG00Ctttiiiiiii;;::i1i1i1iii::,,:ii:,,,,,...
..::,..:it1;,,;;;;:1:;i;:;fti:,,:iiii;:.,i11i;,.;L00CLLftttffttftffttiiii1;;1iiiii;;::,:;;i:,.....,,
,...::. ;t1;,:;::;;i;i::,iLLi:,,;i;;;:.:1tffG0Ct:.:iii;;;;;;;;ii1ttfft11111i;i;;iii;::,:;i1,   .,.,,
.,,..,,.;fti,:;::;;i:,,;,;CL1:,:;i;:,.;1tfLG80Gfi;:,::;i;;;;;iiii;;itLfft1111i;iiii;;;,;ii1...,,:,,,
..,,..,.iLti:,i;;;:;,;i,.;CL1:,:;;;:,i1tLL080Li;ii11i;::;iii111t1i;;itffftf1ii:;i;i;;:,;i1t,......,,
;;;;iii;1fi;:::,:;:i;;:,.;LL1:::;;:,:ttfLG80Lii1tffLLf1;::;1ttttft1i;;tLtffti;:::;i;;:,;i1f;::::::::
;;iiiii;1fti:,ii;;,;:;::,;LLi:,:;;:.;tffL00Li;1tfLLCLttt1i,,,,;ttft1i;:tfftft;;::;;;;:,;1tfiiiiiiiii
iiiii11iit1;,,::,,,;:,.:,;Lfi:,:;;,,i1tfCGGt;11tffLLt1t11i  .  1ttftti;iLffffi;:,:::;:,;1ffi;ii;;;;;
iiiiiiiii11i,,::,,,;:;;,.;LLi:::;;,,;1ttLCCt;i111ttttt1;:  ,,,iftCLff1iiLffLf1i:,,::::,i1tt1iiiiiiii
iiii;iiii1i:.,;;:,,;:;:,.;CCt:::;:,,;i1ttLLt;i11t1tt1;::.,tfffffCGCLftiiLfft1ii:.,::::,:i1tiiiiiiiii
;;;;;;iiii;,.,,.,,,;::,;,;CCi,,,;:,,:;i11LCt;i111LLt:ii;ift11tffLLLft1;tCfftt1;:,:::::,:;itiiiiiiiii
.....,,,:i:,..;;::,;:;,:,;ft;,,.:::,,:;;itff1iit1Lf1tt111iiii1111ttt1iiCLft1ii:,,::;;:,:;;1iii;;;;;;
     .. :1;:..,,,,,:,::::;t1;,,.:::,,::;;i1ttiiii11t111iii;;:;;ii11i;;fftt1i;:,,:::;;:,:;11i;iii;;ii
.,......:i;:..,,,,.:.,;::;t1;,,.::::,.,::;i1tt1itfft1111i;;;;;;ii;;;itt11iii:,.,,,:::,,:;i1;::::::::
:::::::::i;:..::,,.:.,:;::1i;,:.,,,,,..,::;itffLCtiiiii;;;;;;;;;;;i1111ii;;:,.,,,,::::,:;ii1iiiiiiii
.,,,,,:::;;,..,...,:,,,:::ii;,,,,,,,,,..,,::1fff1ttt1iii;;;;iiii11iii;;;;:,..,,,::::::,:;ii,,::::::;
   .. ..:i;,..;;::,;.:i,,,ii:,,.,:,,,,.  .:1ttt11ftffffLfLffLft1ii;;;:::,.,,,,,:::::::,,;ii..... .. 
.,,.  ,.:i;,.,,.,,:i::::,,i;:,,.,:::;:,,:;1t1ii;iiii11tttt1111i;;;;:,,,...,,:::;i;;:::,,;11,......  
,,..,,,.,;:,..:::::i;i;:.,;::,..,,::;itffftiii;:;::::;;;;iii;;::,,.......,,,:;iii;::::,:;;i. .      
,,:::. .:;;...::,,,;:;;:,,;;:,,...:tLLLft11i;,,,.,,,:::,,,,,,............,,::;i;;::,,:,,;i;,......  
,:;:,.::;;:...,,,..:.;i:,,;;:,..ifLLf11iiii:::,........................,,,::;;;;:,,,::,,:;i:::,,,,,.
::,,;::;:;:,.,:::,,:,,::,.:::.:fLftttt1;;:::,,........................,,,:::;;;::::;::,,,:;:::::::::
,,::;::;;i;::::::,,;,:,,..::,:tt1tfLf1i;:::,,,,.,,,,,,..........,...,,,,,:,:::::;:,::::,,;;:,,,,,,,,
,:;;;:::;i;;;1t;;,,;,,,,.,::1tffLffftti:::,,,,,,,,,,,,,,,,,..,,,,,,,:::::::,:::::,:;i1;;:;i,.....,,,
:;;;:::;;iii::;;;,.,...,..:fLLLLLft1iii:,,..,,,...,,:,,,,,,,,,,,:,,,,,,,,,,:::,,,,::::,;;;;.        
.:;;;;:;itt11iii;;::;:::::fCLfttt1i;;;;:,,,,,,,,,,,,,,,,,..,,,,,,....,,,,::::::::::;;;;;iii.......  
,,::;::;:ii11iiiii;;:;::ifftttt1ii;::::;;;;;:::::;;;;i;;:::::::::::,,:,::::;::;;;::;ii;;:;,   .,,...
,:::;;:;;;::;::;,,,,..:ittLffLLL;:;;,:;;;;::.  .,,,,,,...,::;;::;:,...........:::,. .,::,,,,   .,,,,
,,ii;iii;:::;;:i;,,:,,1tttft1t1ti:,;::;;;;;:,.,,,,,...,,:::,:;;:,,,,,,,,,,,,. .:;:;:,,,,:::::    .,,
;;:;1ii1ii;:ii,:;::,.,:;ttiii;;:,,::::;;;;;,,....  .,::::,...,;;,,:,,,,,,,,,....:;;;:::,.,:::..,.  .
,;i:;ii;iti;;:,i;,1;,::,,;,,,:::;11i;;;;;;;,,   ..,,,:,::,,,:::,;;:,::,:;:,:,.,,.:i;;:;;,..,:..::,. 
:,;;::;;:ii;::,i;;11;;,..,,,,.iLLLf1;;;iiii:,  .,,,,,:::,,,,,,,:,;;::;:,i:::,.,:,,i;:,:;;:,....,::,,
", @"
....:;ii:.    ..,,..  .,:,. .;;;:,,,:,;:;;,,....,,...,:,:,,,:::::::,,,,,.,,,.,,,,,,,::;:,,,.,,,,,:::
     .,;ii;:,.. .,,.,...,,,..;;;:,,,:,;:;;:,.....  ,,::,..,;::::;:::,,,,.,;,,,,,,::;:,:;:,,,..,,,:::
...,.,.,,:;;;;:..,,,:,:,.....;;;;,,,::;:;;:,...  ,.,,,..,:::,,.:;;;;:,:,,,;:,,::;;:,,,,,::;:,,,:,:::
..,,.,:,....,:;;;:,.,,:::,. .;;i;,,:,::;;;:,.  .,,.,..,:::,,,::,:::;;;:,,:i:::ii:,,,,,,,.,::::::,:::
,::,,::,.,....,:;;;:,.,::,,,.:;i;:,:,::;;;:,....,....,::::,,,:,.,:::,:i;:ii;;;;:,::::,,:,.....,:,,::
:,,::;:,,,,,.,,,,,:;;;,..,,,.;;;;:::,::;;;::,.,.,.,,,:::::::,,,,:::;:,:;:;::;;;;:;;;:,,,,,,,,,,:,,::
,,:::::,,:;ii;;;:::::::;;:;11t1i;:::;:::;;;;;;:;;i11i11i111iii;;;::::::;1i;:::;;;:::;:;;;:::::::,,::
,::;;,::;1ff11tii:::,,,:;;1tLLt1t1;:,,,,,,,,,,,,,,,::::::::::::::::::,::;::::::::;i;i1iiiii,.,::,,::
:::::,::;1t1:it;1;::,:,,.,;:;1iit;;:.,,,,,,,,,:,,,::::;:;:::;;:;:::;;:::::::::::,;;iii,i;ii,,::,,,:,
::,,,,;;;ii;:::;:,,::;;:,,;;::i;::;,,,,,,:,::::::,:::;;;::;::::::::::::::;;;;;:::,,:::::;;i::::,,,..
:::::,::i1i:.::,,::;::;i;:ii;,:i;:;i;;:;1ii;;;::::::::::::::::::;::;:;;;i11iii;;;;:,,:,:;;i;::,,..,,
,;;,::::;1i:,,:::::i:;1;i:ii;,.,::,;;;;;i1i;::::,,,,,,::::::::::::::;;;;i1111iii;;;:::,:;;;;,,,,,,::
.:;:,::,;1i:.,:::;:iiiiii;11i,.,,,:;:::::;::,...,:iii1fffft1i;;ii;:::::;ii11tt11ii;;::,,:;i,,:::,,::
,,,:i;:,;ti:.,;i;;;i;1i1;:11i,.,:;1tf1;:::::,:i11fLLCCLLCCCLt1111i;i;::::;ii111111;;::,,:;i::::::,:,
,::.:;;:;fi:,:::;;;1;iii;:11;,,:;i111i;:,,::,:iLG0000000GG00Ctttiiiiiii;;::i1i1i1iii::,,:ii:,,,,,...
..::,..:it1;,,;;;;:1:;i;:;fti:,,:iii;;:.,i1i;:.,1C00CCLftttffttftffttiiii1;;1iiiii;;::,:;;i:,.....,,
,...::. ;t1;,:;::;;i;i::,iLLi:,,;i;;;:.:1tffCGLi,,i1ii;;;;;;;;ii1ttfft11111i;i;;iii;::,:;i1,   .,.,,
.,,..,,.;fti,:;::;;i:,,;,;CL1:,:;i;:,.;1tfLG80Gfi:,,::;i;;;;;iiii;iitLfft1111i;iiii;;;,;ii1...,,:,,,
..,,..,.iLti:,i;;;:;,;i,.;CL1:,:;;;:,i1tLL080Li;ii11i:::;iii111t11;;itLfftf1ii:;i;i;;:,;i1t,......,,
;;;;iii;1fi;:::,:;:i;;:,.;LL1:::;;:,:ttfLG80Lii1tffLLti;::;1ttttft1i;;tLtffti;:::;i;;:,;i1f;::::::::
;;iiiii;1fti:,ii;;,;:;::,;LLi:,:;;:.;tffL00Li;1tfLLCLttt1i,,,,;ttft1i;:tfftft;;::;;;;:,;1tfiiiiiiiii
iiiii11iit1;,,::,,,;:,.:,;Lfi:,:;;,,i1tfCGGt;111fffLt1111i  .  1ttft1;:iLffffi;:,:::;:,;1ffi;ii;;;;;
iiiiiiiii11i,,::,,,;:;;,.;LLi:::;;,,;1ttLCC1;i111ttttt1;:  ,,,iftCLff1iiLffLf1i:,,::::,i1tt1iiiiiiii
iiii;iiii1i:.,;;:,,;:;:,.;CCt:::;:,,;i1ttLLt;i11t1tt1;::.,tfffffCGCLftiiLfft1ii:.,::::,:i1tiiiiiiiii
;;;;;;iiii;,.,,.,,,;::,;,;CCi,,,;:,,:;i11LCt;i1t1LLt:ii;ift11tffLLLft1;tCfftt1;:,:::::,:;itiiiiiiiii
.....,,,:i:,..;;::,;:;,:,;ft;,,.:::,,:;;itff1;it1Lf1tt111iiii1111ttt1iiCLft1ii:,,::;;:,:;;1iii;;;;;;
     .. :1;:..,,,,,:,::::;t1;,,.:::,,::;;i1ttiiii11ti11iii;;:;;ii11i;;fftt1i;:,,:::;;:,:;11i;iii;;ii
.,......:i;:..,,,,.:.,;::;t1;,,.::::,.,::;i1tt1itfft1111i;;;;;iii;;;itt11iii:,.,,,:::,,:;i1;::::::::
:::::::::i;:..::,,.:.,:;::1i;,:.,,,,,..,::;itffLCtiiiii;;;;;;;;;;;i1111ii;;:,.,,,,::::,:;ii1iiiiiiii
.,,,,,:::;;,..,...,:,,,:::ii;,,,,,,,,,..,,::1fff1ttt1iii;;;;iiii11iii;;;;:,..,,,::::::,:;ii,,::::::;
   .. ..:i;,..;;::,;.:i,,,ii:,,.,:,,,,.  .:1ttt11ftffffLfLffLft1ii;;;:::,.,,,,,:::::::,,;ii..... .. 
.,,.  ,.:i;,.,,.,,:i::::,,i;:,,.,:::;:,,,;1t1ii;iiii11tttt1111i;;;;:,,,...,,:::;i;;:::,,;11,......  
,,..,,,.,;:,..:::::i;i;:.,;::...,,::;i1ffftiii;:;;:::;;;;iii;;::,,.......,,,:;iii;::::,:;;i. .      
,,:::. .:;;...::,,,;:;;:,,;;:,,..,:tLLLft11i;,,,.,,,:::,,,,,,............,,::;i;;::,,:,,;i;,......  
,:;:,.::;;:...,,,..:.;i:,,;;:,..;fLLf11iiii:::,........................,,,::;;;;:,,,::,,:;i:::,,,,,.
::,,;::;:;:,.,:::,,:,,:;,.:::.:tLftttt1;;:::,,........................,,,:::;;;::::;::,,,:;:::::::::
,,::;::;;i;::::::,,;,:,,..,:,:tt1tfffti;:::,,,,.,,,,,,..........,...,,,,,:,:::::;:,::::,,;;:,,,,,,,,
,:;;;:::;i;;;1t;;,,;,,,,.,::1tffLffftti:::,,,,,,,,,,,,,,,,,..,,,,,,,:::::::,:::::,:;i1;;:;i,.....,,,
:;;;:::;;iii::;;;,.,...,..:fLfLLLtt1iii:,,..,,,...,,:,,,,,,,,,,,:,,,,,,,,,,:::,,,,::::,;;;;.        
.:;;;;:;itt11iiii;::;:::::fCLfttt1i;;;;;,,,,,,,,,,,,,,,,,..,,,,,,....,,,,::::::::::;;;;;iii.......  
,,::;::;:ii11iiiii;;:;::;fLtttt1ii;::::;;;;;:::::;;;;i;;:::::::::::,,:,::::;::;;;::;ii;;:;,   .,,...
,:::;;:;;;::;::;,,,,..,ittfffLLL;:;;,:;;;;::.  .,,,,,,...,::;;::;:,...........:::,. .,::,,,,   .,,,,
,,ii;iii;:::;;:i;,,:,,1tttft1t1ti,,:::;;;;;:,.,,,,,...,,:::,:;;:,,,,,,,,,,,,. .:;:;:,,,,:::::    .,,
;;:;1ii1ii;:ii,:;::,.,:;ttiii;;:,,::::;;;;;,,....  .,::::,...,;;,,:,,,,,,,,,....:;;;:::,.,:::..,.  .
,;i:;ii;iti;;:,i;,1;,::,,i,,,:::;11i;;;;;;;,,   ..,,,:,::,,,:::,;;:,::,:;:,:,.,,.:i;;:;;,..,:..::,. 
:,;;::;;:ii;::,i;;11;;,..,:,,.ifLLf1;;;iiii:,  .,,,,,:::,,,,,,,:,;;::;:,i:::,.,:,,i;:,:;;:,....,::,,
" };
        
    }
}


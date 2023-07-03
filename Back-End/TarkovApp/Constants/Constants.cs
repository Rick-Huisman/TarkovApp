namespace TarkovApp.Constants;

public static class Constants
{
    // Connection to Api
    public const string TarkovApiEndpoint = "https://api.tarkov.dev/graphql";
    public const string TarkovApiQueryString = "query";

    // Item Attributes
    public const string AllItemProperties =
        "id name normalizedName shortName description basePrice updated width height backgroundColor iconLink gridImageLink baseImageLink inspectImageLink image512pxLink image8xLink wikiLink types avg24hPrice properties conflictingItems conflictingSlotIds accuracyModifier recoilModifier ergonomicsModifier hasGrid blocksHeadphones link lastLowPrice changeLast48h changeLast48hPercent low24hPrice high24hPrice lastOfferCount sellFor buyFor containsItems category categories bsgCategoryId handbookCategories weight velocity loudness usedInTasks receivedFromTasks bartersFor bartersUsing craftsFor craftsUsing";

    public const string BasicItemProperties =
        "id name normalizedName shortName description basePrice updated width height backgroundColor iconLink";

    // Misc
    public const string TarkovAppLogo = @"
         'I~~!ll:; !<i!i[}"" ]}?]><><,;1)~,>1)+`{1]     .){i;^;;"".         }](^     :}}['?}};._}}<!}[^ i}},;}}}[`[_>.         
       .~_??[{)1{}{(\|()>   ""\{;,i+,;l""'`.. ?tttttttt/})?~~""`. >(///\l  ""`/t/>i""    >[)l,```..``.. .1|{]??_  ./||(}_'        
       .\urvczB&##88$B%Bj  'B@8zuv1\W8*:l;' v$$$$$$$$@$$$BW*{'.$$$$$%W ]v/@$$$x    :Muc]x|~~+}!`'..'B&88M*n  '%8M&nn,        
       .*###*W888%B8&MWM{  /BB&88x  '(czBc{ v$$$$$$xfv&$$$$8z,.$$$$$$@/$$$$$$v.   `%Wzz\~l[|{u[)1<"".@$$$%%#  '8W#)^``        
            i&%%B@@>      [@@B%_""'   ' '"""""" ~{{B$$$""  ~$$$$$@i.$$$$$$$$$$$$$%'    cBB8&*'  .&&W8Wf`'j%$$@B#  'WM&].          
            i8%@@@B>     .@$$B'      .; /8* v$$$$$$^  ~$$$$$M>.$$$$$$$$$$$$%`    `@$@BB&,  .&%BB<:'.;;(B%Wv  '%8B('          
            >B$$$$$>     .@$$+      .``f$$M v$$$$$$'  ~$$$$$*i.B@@$$$$$$$$$$`    ""B$$%%#i   "";c#''  '..:!>{^ <8BM?.          
            >@$$$$$>     '$$$^       #$$$$M v$$$$$$1}?n$$$$$u` \*%$$$&M$$$$$u    `B@8t:,'   ,if~    .'.!\/\<.M%%M_'.         
            >$$$$$$>     '$$$t     'tBB$$$M v$$$$$$$$$@&&$$%t"" ]jz$$$~""$$$@$@`   :@@8-'     ]##v.;.  . ^:'`!tBB%\...         
            >$$$$$$>     '$Bcv'     +*&@$$M )n*]cM@B8Br^&@B8j. !c<$$$<""$$$$$$~   ,v+*>'`.   ,|1j."".    ,_/vx*cr]^ '          
            >@$$$$%;     '@8|}.      ?Wz*Mj '\8?c,,Iz8ur""8z    :r'%$*:`j[cB&%;.  :\-zI.`.   `l`. .    .^`'`'^`... .          
            ,fW&%x/^     'uv*_.  :'  .z;,_,  `,`"",'.""~-<[;v""   ^"" ->..  .<x^'..  ...:'.^`   ;I....    .'..   .  ...          
            .,l<\,,.     .I>/.  ^,[  't-_x_  .`""I<"".`/nnf:l""   .  ..     `;.' .     `....'..,`.'^'     .   . ''''.           
             .'',..       ..'   ""'^  .^`""^.    ....  ```.^ .    .. ..'   .'         `'.'....'.'``      . ``. ``^.            
                                                       .        .    .    .   '     `..... .'..'         `^' '``.   
    ";
}
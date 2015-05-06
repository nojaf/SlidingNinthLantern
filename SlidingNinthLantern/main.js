import {LogManager} from "aurelia-framework";
import {ConsoleAppender} from "aurelia-logging-console";
import {ConventionalViewStrategy} from "aurelia-framework";

LogManager.addAppender(new ConsoleAppender());
LogManager.setLevel(LogManager.logLevel.debug);

export function configure(aurelia) {
    aurelia.use
        .standardConfiguration()
        .developmentLogging();

    ConventionalViewStrategy.convertModuleIdToViewUrl = function(moduleId){
        var moduleName = moduleId.replace("Scripts/", "");
        return `./Templates/${moduleName}`;
    }


    aurelia.start().then(a => a.setRoot("./Scripts/lantern", document.body));
}

/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

using Newtonsoft.Json;

namespace RosSharp.RosBridgeClient.MessageTypes.Utbot
{
    public class LyftProScanZoneList : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "utbot_msgs/LyftProScanZoneList";

        public LyftProScanZone[] scan_zones;

        public LyftProScanZoneList()
        {
            this.scan_zones = new LyftProScanZone[0];
        }

        public LyftProScanZoneList(LyftProScanZone[] scan_zones)
        {
            this.scan_zones = scan_zones;
        }
    }
}

using System.Collections.Generic;

public class ConstellationData
{
    public ConstellationNameData Name;            // 星座名のデータ
    public ConstellationPositionData Position;    // 星座位置
    public List<StarData> Stars;                      // 星の位置
    public List<ConstellationLineData> Lines;         // 星座線のデータ
}
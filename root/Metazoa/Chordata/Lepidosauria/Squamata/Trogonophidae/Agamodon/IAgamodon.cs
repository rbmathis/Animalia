namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Trogonophidae.Agamodon;

/// <summary>
/// Interface defining characteristics of Agamodon (genus).
/// </summary>
public interface IAgamodon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

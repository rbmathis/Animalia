namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Cylindrophiidae.Cylindrophis;

/// <summary>
/// Interface defining characteristics of Cylindrophis (genus).
/// </summary>
public interface ICylindrophis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

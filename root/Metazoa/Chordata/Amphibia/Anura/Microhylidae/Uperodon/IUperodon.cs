namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Uperodon;

/// <summary>
/// Interface defining characteristics of Uperodon (genus).
/// </summary>
public interface IUperodon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

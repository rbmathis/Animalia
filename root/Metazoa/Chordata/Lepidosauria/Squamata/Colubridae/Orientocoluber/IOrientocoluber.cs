namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Orientocoluber;

/// <summary>
/// Interface defining characteristics of Orientocoluber (genus).
/// </summary>
public interface IOrientocoluber
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

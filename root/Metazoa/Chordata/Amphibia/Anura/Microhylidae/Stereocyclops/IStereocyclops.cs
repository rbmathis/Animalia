namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Stereocyclops;

/// <summary>
/// Interface defining characteristics of Stereocyclops (genus).
/// </summary>
public interface IStereocyclops
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Sclerophrys;

/// <summary>
/// Interface defining characteristics of Sclerophrys (genus).
/// </summary>
public interface ISclerophrys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

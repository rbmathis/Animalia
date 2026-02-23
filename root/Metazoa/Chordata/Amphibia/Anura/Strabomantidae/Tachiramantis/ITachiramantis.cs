namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Strabomantidae.Tachiramantis;

/// <summary>
/// Interface defining characteristics of Tachiramantis (genus).
/// </summary>
public interface ITachiramantis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

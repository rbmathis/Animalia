namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Strabomantidae.Strabomantis;

/// <summary>
/// Interface defining characteristics of Strabomantis (genus).
/// </summary>
public interface IStrabomantis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

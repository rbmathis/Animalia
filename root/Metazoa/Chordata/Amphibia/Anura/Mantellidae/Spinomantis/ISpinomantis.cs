namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Mantellidae.Spinomantis;

/// <summary>
/// Interface defining characteristics of Spinomantis (genus).
/// </summary>
public interface ISpinomantis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

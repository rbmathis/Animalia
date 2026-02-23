namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Mantellidae.Guibemantis;

/// <summary>
/// Interface defining characteristics of Guibemantis (genus).
/// </summary>
public interface IGuibemantis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

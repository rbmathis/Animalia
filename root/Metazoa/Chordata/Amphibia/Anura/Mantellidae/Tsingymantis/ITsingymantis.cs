namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Mantellidae.Tsingymantis;

/// <summary>
/// Interface defining characteristics of Tsingymantis (genus).
/// </summary>
public interface ITsingymantis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

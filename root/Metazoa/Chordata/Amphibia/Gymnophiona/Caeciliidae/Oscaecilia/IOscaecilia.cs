namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Caeciliidae.Oscaecilia;

/// <summary>
/// Interface defining characteristics of Oscaecilia (genus).
/// </summary>
public interface IOscaecilia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

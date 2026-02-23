namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Caeciliidae.Caecilia;

/// <summary>
/// Interface defining characteristics of Caecilia (genus).
/// </summary>
public interface ICaecilia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

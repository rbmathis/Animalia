namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Percichthyidae.Gadopsis;

/// <summary>
/// Interface defining characteristics of Gadopsis (genus).
/// </summary>
public interface IGadopsis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Mantellidae.Blommersia;

/// <summary>
/// Interface defining characteristics of Blommersia (genus).
/// </summary>
public interface IBlommersia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

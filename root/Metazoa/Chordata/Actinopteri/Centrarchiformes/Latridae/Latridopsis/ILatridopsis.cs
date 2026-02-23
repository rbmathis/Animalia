namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Latridae.Latridopsis;

/// <summary>
/// Interface defining characteristics of Latridopsis (genus).
/// </summary>
public interface ILatridopsis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

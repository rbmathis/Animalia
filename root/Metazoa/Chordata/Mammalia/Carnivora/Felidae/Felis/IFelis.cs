namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Felis;

/// <summary>
/// Interface defining characteristics of Felis (genus).
/// </summary>
public interface IFelis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

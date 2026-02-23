namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Pardofelis;

/// <summary>
/// Interface defining characteristics of Pardofelis (genus).
/// </summary>
public interface IPardofelis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

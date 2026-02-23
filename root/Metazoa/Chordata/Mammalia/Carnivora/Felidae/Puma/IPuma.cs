namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Puma;

/// <summary>
/// Interface defining characteristics of Puma (genus).
/// </summary>
public interface IPuma
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae.Pseudonezumia;

/// <summary>
/// Interface defining characteristics of Pseudonezumia (genus).
/// </summary>
public interface IPseudonezumia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

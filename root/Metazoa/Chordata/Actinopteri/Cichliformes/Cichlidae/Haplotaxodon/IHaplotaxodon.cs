namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Haplotaxodon;

/// <summary>
/// Interface defining characteristics of Haplotaxodon (genus).
/// </summary>
public interface IHaplotaxodon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

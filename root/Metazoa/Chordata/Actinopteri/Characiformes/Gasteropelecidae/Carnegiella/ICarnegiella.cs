namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Gasteropelecidae.Carnegiella;

/// <summary>
/// Interface defining characteristics of Carnegiella (genus).
/// </summary>
public interface ICarnegiella
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

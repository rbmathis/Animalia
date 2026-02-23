namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Monotocheirodon;

/// <summary>
/// Interface defining characteristics of Monotocheirodon (genus).
/// </summary>
public interface IMonotocheirodon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

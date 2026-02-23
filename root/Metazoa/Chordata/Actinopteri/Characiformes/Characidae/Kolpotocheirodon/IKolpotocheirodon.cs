namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Kolpotocheirodon;

/// <summary>
/// Interface defining characteristics of Kolpotocheirodon (genus).
/// </summary>
public interface IKolpotocheirodon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

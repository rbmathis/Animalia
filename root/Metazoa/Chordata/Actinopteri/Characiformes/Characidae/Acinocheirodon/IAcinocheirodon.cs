namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Acinocheirodon;

/// <summary>
/// Interface defining characteristics of Acinocheirodon (genus).
/// </summary>
public interface IAcinocheirodon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

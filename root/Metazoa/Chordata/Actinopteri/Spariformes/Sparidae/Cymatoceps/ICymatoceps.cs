namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Cymatoceps;

/// <summary>
/// Interface defining characteristics of Cymatoceps (genus).
/// </summary>
public interface ICymatoceps
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

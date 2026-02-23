namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Esociformes.Umbridae.Dallia;

/// <summary>
/// Interface defining characteristics of Dallia (genus).
/// </summary>
public interface IDallia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Bregmacerotidae.Bregmaceros;

/// <summary>
/// Interface defining characteristics of Bregmaceros (genus).
/// </summary>
public interface IBregmaceros
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

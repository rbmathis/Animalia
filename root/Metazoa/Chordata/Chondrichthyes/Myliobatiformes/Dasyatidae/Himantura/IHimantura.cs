namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Dasyatidae.Himantura;

/// <summary>
/// Interface defining characteristics of Himantura (genus).
/// </summary>
public interface IHimantura
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

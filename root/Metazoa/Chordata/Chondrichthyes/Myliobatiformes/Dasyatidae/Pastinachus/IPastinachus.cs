namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Dasyatidae.Pastinachus;

/// <summary>
/// Interface defining characteristics of Pastinachus (genus).
/// </summary>
public interface IPastinachus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

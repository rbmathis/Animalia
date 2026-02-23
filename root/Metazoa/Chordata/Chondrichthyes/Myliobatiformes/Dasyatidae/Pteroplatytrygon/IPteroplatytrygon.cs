namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Dasyatidae.Pteroplatytrygon;

/// <summary>
/// Interface defining characteristics of Pteroplatytrygon (genus).
/// </summary>
public interface IPteroplatytrygon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

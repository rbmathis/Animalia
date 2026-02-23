namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Icosteidae.Icosteus;

/// <summary>
/// Interface defining characteristics of Icosteus (genus).
/// </summary>
public interface IIcosteus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

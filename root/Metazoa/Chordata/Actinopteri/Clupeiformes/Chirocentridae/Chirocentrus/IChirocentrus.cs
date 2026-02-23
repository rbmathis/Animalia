namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Chirocentridae.Chirocentrus;

/// <summary>
/// Interface defining characteristics of Chirocentrus (genus).
/// </summary>
public interface IChirocentrus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

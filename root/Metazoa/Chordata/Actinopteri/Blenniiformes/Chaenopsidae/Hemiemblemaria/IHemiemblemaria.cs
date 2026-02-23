namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Chaenopsidae.Hemiemblemaria;

/// <summary>
/// Interface defining characteristics of Hemiemblemaria (genus).
/// </summary>
public interface IHemiemblemaria
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

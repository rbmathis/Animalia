namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Chaenopsidae.Emblemariopsis;

/// <summary>
/// Interface defining characteristics of Emblemariopsis (genus).
/// </summary>
public interface IEmblemariopsis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

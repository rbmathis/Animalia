namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Bagridae.Hyalobagrus;

/// <summary>
/// Interface defining characteristics of Hyalobagrus (genus).
/// </summary>
public interface IHyalobagrus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

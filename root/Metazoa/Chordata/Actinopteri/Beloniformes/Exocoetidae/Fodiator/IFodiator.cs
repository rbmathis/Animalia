namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Exocoetidae.Fodiator;

/// <summary>
/// Interface defining characteristics of Fodiator (genus).
/// </summary>
public interface IFodiator
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

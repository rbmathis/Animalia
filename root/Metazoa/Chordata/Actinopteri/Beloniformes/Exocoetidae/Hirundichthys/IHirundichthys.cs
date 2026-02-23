namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Exocoetidae.Hirundichthys;

/// <summary>
/// Interface defining characteristics of Hirundichthys (genus).
/// </summary>
public interface IHirundichthys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

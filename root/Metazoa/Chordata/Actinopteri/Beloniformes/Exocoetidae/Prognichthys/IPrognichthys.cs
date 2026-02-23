namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Exocoetidae.Prognichthys;

/// <summary>
/// Interface defining characteristics of Prognichthys (genus).
/// </summary>
public interface IPrognichthys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

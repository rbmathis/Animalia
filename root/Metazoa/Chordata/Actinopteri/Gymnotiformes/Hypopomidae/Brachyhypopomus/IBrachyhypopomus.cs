namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Hypopomidae.Brachyhypopomus;

/// <summary>
/// Interface defining characteristics of Brachyhypopomus (genus).
/// </summary>
public interface IBrachyhypopomus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Microstomatidae.Xenophthalmichthys;

/// <summary>
/// Interface defining characteristics of Xenophthalmichthys (genus).
/// </summary>
public interface IXenophthalmichthys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

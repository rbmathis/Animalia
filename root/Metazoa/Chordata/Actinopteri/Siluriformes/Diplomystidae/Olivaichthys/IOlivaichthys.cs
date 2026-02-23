namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Diplomystidae.Olivaichthys;

/// <summary>
/// Interface defining characteristics of Olivaichthys (genus).
/// </summary>
public interface IOlivaichthys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

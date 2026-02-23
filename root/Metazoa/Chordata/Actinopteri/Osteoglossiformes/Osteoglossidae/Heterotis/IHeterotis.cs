namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Osteoglossidae.Heterotis;

/// <summary>
/// Interface defining characteristics of Heterotis (genus).
/// </summary>
public interface IHeterotis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

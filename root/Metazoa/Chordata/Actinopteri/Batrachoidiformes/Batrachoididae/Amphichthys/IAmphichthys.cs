namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Batrachoidiformes.Batrachoididae.Amphichthys;

/// <summary>
/// Interface defining characteristics of Amphichthys (genus).
/// </summary>
public interface IAmphichthys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

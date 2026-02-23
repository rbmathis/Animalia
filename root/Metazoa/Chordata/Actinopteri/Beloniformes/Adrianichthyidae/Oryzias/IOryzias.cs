namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Adrianichthyidae.Oryzias;

/// <summary>
/// Interface defining characteristics of Oryzias (genus).
/// </summary>
public interface IOryzias
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

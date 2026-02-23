namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Phosichthyidae.Pollichthys;

/// <summary>
/// Interface defining characteristics of Pollichthys (genus).
/// </summary>
public interface IPollichthys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

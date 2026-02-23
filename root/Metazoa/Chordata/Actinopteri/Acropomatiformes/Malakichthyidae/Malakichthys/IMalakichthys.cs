namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Malakichthyidae.Malakichthys;

/// <summary>
/// Interface defining characteristics of Malakichthys (genus).
/// </summary>
public interface IMalakichthys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

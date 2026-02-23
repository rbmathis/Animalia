namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Percichthyidae.Percichthys;

/// <summary>
/// Interface defining characteristics of Percichthys (genus).
/// </summary>
public interface IPercichthys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

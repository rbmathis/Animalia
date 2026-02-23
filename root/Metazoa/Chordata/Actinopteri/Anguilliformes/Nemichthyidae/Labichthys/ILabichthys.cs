namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Nemichthyidae.Labichthys;

/// <summary>
/// Interface defining characteristics of Labichthys (genus).
/// </summary>
public interface ILabichthys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

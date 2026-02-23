namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Nemichthyidae.Avocettina;

/// <summary>
/// Interface defining characteristics of Avocettina (genus).
/// </summary>
public interface IAvocettina
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

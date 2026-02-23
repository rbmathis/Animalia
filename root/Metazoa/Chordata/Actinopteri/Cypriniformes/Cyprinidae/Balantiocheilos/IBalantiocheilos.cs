namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Balantiocheilos;

/// <summary>
/// Interface defining characteristics of Balantiocheilos (genus).
/// </summary>
public interface IBalantiocheilos
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

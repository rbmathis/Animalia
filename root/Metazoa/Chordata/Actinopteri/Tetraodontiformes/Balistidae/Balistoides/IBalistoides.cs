namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Balistidae.Balistoides;

/// <summary>
/// Interface defining characteristics of Balistoides (genus).
/// </summary>
public interface IBalistoides
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

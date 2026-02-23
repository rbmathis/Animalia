namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Badidae.Dario;

/// <summary>
/// Interface defining characteristics of Dario (genus).
/// </summary>
public interface IDario
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

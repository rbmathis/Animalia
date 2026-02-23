namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Protanguillidae.Protanguilla;

/// <summary>
/// Interface defining characteristics of Protanguilla (genus).
/// </summary>
public interface IProtanguilla
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

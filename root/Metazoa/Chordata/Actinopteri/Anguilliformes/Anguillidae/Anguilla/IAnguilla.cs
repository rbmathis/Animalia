namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Anguillidae.Anguilla;

/// <summary>
/// Interface defining characteristics of Anguilla (genus).
/// </summary>
public interface IAnguilla
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

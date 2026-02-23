namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Nettastomatidae.Venefica;

/// <summary>
/// Interface defining characteristics of Venefica (genus).
/// </summary>
public interface IVenefica
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

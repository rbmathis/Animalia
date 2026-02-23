namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Esociformes.Esocidae.Esox;

/// <summary>
/// Interface defining characteristics of Esox (genus).
/// </summary>
public interface IEsox
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Paralepididae.Paralepis;

/// <summary>
/// Interface defining characteristics of Paralepis (genus).
/// </summary>
public interface IParalepis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

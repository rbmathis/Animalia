namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Uranoscopiformes.Pinguipedidae.Parapercis;

/// <summary>
/// Interface defining characteristics of Parapercis (genus).
/// </summary>
public interface IParapercis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

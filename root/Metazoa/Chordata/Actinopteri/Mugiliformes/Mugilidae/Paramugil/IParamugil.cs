namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae.Paramugil;

/// <summary>
/// Interface defining characteristics of Paramugil (genus).
/// </summary>
public interface IParamugil
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

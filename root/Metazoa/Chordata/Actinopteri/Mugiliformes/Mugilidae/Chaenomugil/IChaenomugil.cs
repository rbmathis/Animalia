namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae.Chaenomugil;

/// <summary>
/// Interface defining characteristics of Chaenomugil (genus).
/// </summary>
public interface IChaenomugil
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

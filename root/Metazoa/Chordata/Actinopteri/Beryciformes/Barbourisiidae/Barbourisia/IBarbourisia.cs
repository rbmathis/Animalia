namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Barbourisiidae.Barbourisia;

/// <summary>
/// Interface defining characteristics of Barbourisia (genus).
/// </summary>
public interface IBarbourisia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

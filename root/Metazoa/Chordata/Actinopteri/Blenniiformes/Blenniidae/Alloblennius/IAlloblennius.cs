namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Alloblennius;

/// <summary>
/// Interface defining characteristics of Alloblennius (genus).
/// </summary>
public interface IAlloblennius
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

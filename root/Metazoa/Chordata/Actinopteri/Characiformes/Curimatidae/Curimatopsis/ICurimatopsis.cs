namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Curimatidae.Curimatopsis;

/// <summary>
/// Interface defining characteristics of Curimatopsis (genus).
/// </summary>
public interface ICurimatopsis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

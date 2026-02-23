namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Rondeletiidae.Rondeletia;

/// <summary>
/// Interface defining characteristics of Rondeletia (genus).
/// </summary>
public interface IRondeletia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

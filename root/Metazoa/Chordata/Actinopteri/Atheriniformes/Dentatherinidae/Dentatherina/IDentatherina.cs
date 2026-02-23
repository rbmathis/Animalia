namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Dentatherinidae.Dentatherina;

/// <summary>
/// Interface defining characteristics of Dentatherina (genus).
/// </summary>
public interface IDentatherina
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

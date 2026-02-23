namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Telmatherinidae.Telmatherina;

/// <summary>
/// Interface defining characteristics of Telmatherina (genus).
/// </summary>
public interface ITelmatherina
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

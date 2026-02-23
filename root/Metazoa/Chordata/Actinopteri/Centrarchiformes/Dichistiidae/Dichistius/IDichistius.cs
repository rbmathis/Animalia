namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Dichistiidae.Dichistius;

/// <summary>
/// Interface defining characteristics of Dichistius (genus).
/// </summary>
public interface IDichistius
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

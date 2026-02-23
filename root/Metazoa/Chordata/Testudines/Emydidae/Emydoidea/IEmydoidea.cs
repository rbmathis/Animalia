namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Emydoidea;

/// <summary>
/// Interface defining characteristics of Emydoidea (genus).
/// </summary>
public interface IEmydoidea
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

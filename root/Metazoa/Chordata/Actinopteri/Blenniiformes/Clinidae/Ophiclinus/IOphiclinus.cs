namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Clinidae.Ophiclinus;

/// <summary>
/// Interface defining characteristics of Ophiclinus (genus).
/// </summary>
public interface IOphiclinus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

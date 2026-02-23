namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Synanceiidae.Choridactylus;

/// <summary>
/// Interface defining characteristics of Choridactylus (genus).
/// </summary>
public interface IChoridactylus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

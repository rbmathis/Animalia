namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Phaenicophilus;

/// <summary>
/// Interface defining characteristics of Phaenicophilus (genus).
/// </summary>
public interface IPhaenicophilus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cinclidae.Cinclus;

/// <summary>
/// Interface defining characteristics of Cinclus (genus).
/// </summary>
public interface ICinclus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

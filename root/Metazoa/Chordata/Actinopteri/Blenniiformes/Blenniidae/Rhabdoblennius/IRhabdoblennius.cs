namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Rhabdoblennius;

/// <summary>
/// Interface defining characteristics of Rhabdoblennius (genus).
/// </summary>
public interface IRhabdoblennius
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

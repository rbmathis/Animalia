namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gonorynchiformes.Chanidae.Chanos;

/// <summary>
/// Interface defining characteristics of Chanos (genus).
/// </summary>
public interface IChanos
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

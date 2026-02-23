namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Megadermatidae.Lavia;

/// <summary>
/// Interface defining characteristics of Lavia (genus).
/// </summary>
public interface ILavia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Tinamiformes.Tinamidae.Tinamus;

/// <summary>
/// Interface defining characteristics of Tinamus (genus).
/// </summary>
public interface ITinamus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

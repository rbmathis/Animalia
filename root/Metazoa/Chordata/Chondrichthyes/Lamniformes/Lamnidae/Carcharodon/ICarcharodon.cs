namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Lamniformes.Lamnidae.Carcharodon;

/// <summary>
/// Interface defining characteristics of Carcharodon (genus).
/// </summary>
public interface ICarcharodon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

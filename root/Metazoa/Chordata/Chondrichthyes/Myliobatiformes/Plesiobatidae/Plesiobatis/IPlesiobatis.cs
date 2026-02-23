namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Plesiobatidae.Plesiobatis;

/// <summary>
/// Interface defining characteristics of Plesiobatis (genus).
/// </summary>
public interface IPlesiobatis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

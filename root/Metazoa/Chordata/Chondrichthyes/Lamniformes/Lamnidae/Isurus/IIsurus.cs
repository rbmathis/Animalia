namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Lamniformes.Lamnidae.Isurus;

/// <summary>
/// Interface defining characteristics of Isurus (genus).
/// </summary>
public interface IIsurus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

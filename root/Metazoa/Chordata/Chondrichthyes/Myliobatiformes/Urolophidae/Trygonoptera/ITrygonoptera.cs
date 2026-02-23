namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Urolophidae.Trygonoptera;

/// <summary>
/// Interface defining characteristics of Trygonoptera (genus).
/// </summary>
public interface ITrygonoptera
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

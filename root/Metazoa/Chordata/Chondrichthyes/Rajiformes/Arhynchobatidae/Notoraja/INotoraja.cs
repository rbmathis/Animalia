namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Arhynchobatidae.Notoraja;

/// <summary>
/// Interface defining characteristics of Notoraja (genus).
/// </summary>
public interface INotoraja
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

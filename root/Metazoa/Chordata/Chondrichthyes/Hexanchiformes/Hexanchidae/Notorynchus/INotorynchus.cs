namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Hexanchiformes.Hexanchidae.Notorynchus;

/// <summary>
/// Interface defining characteristics of Notorynchus (genus).
/// </summary>
public interface INotorynchus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

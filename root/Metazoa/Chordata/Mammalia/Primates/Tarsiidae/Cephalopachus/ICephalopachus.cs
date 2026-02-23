namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Tarsiidae.Cephalopachus;

/// <summary>
/// Interface defining characteristics of Cephalopachus (genus).
/// </summary>
public interface ICephalopachus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

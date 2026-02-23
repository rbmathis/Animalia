namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Dasyuromorphia.Myrmecobiidae.Myrmecobius;

/// <summary>
/// Interface defining characteristics of Myrmecobius (genus).
/// </summary>
public interface IMyrmecobius
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

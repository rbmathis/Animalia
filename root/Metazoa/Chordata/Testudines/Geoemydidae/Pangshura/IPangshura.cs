namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Pangshura;

/// <summary>
/// Interface defining characteristics of Pangshura (genus).
/// </summary>
public interface IPangshura
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

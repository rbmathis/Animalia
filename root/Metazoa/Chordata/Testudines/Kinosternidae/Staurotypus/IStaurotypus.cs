namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Kinosternidae.Staurotypus;

/// <summary>
/// Interface defining characteristics of Staurotypus (genus).
/// </summary>
public interface IStaurotypus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

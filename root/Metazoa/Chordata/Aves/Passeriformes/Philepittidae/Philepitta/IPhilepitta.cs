namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Philepittidae.Philepitta;

/// <summary>
/// Interface defining characteristics of Philepitta (genus).
/// </summary>
public interface IPhilepitta
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

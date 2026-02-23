namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Hirundinidae.Ptyonoprogne;

/// <summary>
/// Interface defining characteristics of Ptyonoprogne (genus).
/// </summary>
public interface IPtyonoprogne
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

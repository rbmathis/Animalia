namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Cirrhitidae.Oxycirrhites;

/// <summary>
/// Interface defining characteristics of Oxycirrhites (genus).
/// </summary>
public interface IOxycirrhites
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Oreomystis;

/// <summary>
/// Interface defining characteristics of Oreomystis (genus).
/// </summary>
public interface IOreomystis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae.Lampropsar;

/// <summary>
/// Interface defining characteristics of Lampropsar (genus).
/// </summary>
public interface ILampropsar
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

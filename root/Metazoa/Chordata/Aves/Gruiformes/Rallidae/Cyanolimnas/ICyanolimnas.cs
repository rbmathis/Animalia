namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Cyanolimnas;

/// <summary>
/// Interface defining characteristics of Cyanolimnas (genus).
/// </summary>
public interface ICyanolimnas
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

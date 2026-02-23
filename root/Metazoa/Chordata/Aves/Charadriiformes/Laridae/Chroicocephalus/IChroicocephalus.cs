namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Chroicocephalus;

/// <summary>
/// Interface defining characteristics of Chroicocephalus (genus).
/// </summary>
public interface IChroicocephalus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Lophophorus;

/// <summary>
/// Interface defining characteristics of Lophophorus (genus).
/// </summary>
public interface ILophophorus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

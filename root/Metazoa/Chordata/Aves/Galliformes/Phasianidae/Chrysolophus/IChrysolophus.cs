namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Chrysolophus;

/// <summary>
/// Interface defining characteristics of Chrysolophus (genus).
/// </summary>
public interface IChrysolophus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Callulops;

/// <summary>
/// Interface defining characteristics of Callulops (genus).
/// </summary>
public interface ICallulops
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

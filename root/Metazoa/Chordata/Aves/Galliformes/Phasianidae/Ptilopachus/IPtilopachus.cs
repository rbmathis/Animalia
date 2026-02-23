namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Ptilopachus;

/// <summary>
/// Interface defining characteristics of Ptilopachus (genus).
/// </summary>
public interface IPtilopachus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

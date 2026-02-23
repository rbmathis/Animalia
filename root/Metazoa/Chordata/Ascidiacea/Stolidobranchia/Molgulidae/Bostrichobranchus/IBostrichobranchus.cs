namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Molgulidae.Bostrichobranchus;

/// <summary>
/// Interface defining characteristics of Bostrichobranchus (genus).
/// </summary>
public interface IBostrichobranchus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

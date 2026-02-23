namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Euherdmaniidae.Euherdmania;

/// <summary>
/// Interface defining characteristics of Euherdmania (genus).
/// </summary>
public interface IEuherdmania
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

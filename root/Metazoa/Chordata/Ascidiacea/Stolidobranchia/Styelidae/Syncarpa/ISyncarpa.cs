namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Styelidae.Syncarpa;

/// <summary>
/// Interface defining characteristics of Syncarpa (genus).
/// </summary>
public interface ISyncarpa
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

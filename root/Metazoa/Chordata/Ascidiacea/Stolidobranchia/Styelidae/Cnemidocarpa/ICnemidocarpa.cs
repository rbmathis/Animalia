namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Styelidae.Cnemidocarpa;

/// <summary>
/// Interface defining characteristics of Cnemidocarpa (genus).
/// </summary>
public interface ICnemidocarpa
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

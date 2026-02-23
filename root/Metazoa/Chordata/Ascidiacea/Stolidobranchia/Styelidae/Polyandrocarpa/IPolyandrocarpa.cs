namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Styelidae.Polyandrocarpa;

/// <summary>
/// Interface defining characteristics of Polyandrocarpa (genus).
/// </summary>
public interface IPolyandrocarpa
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

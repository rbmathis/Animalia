namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Styelidae.Metandrocarpa;

/// <summary>
/// Interface defining characteristics of Metandrocarpa (genus).
/// </summary>
public interface IMetandrocarpa
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

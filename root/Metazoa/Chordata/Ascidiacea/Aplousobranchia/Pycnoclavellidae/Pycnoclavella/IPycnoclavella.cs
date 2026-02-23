namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Pycnoclavellidae.Pycnoclavella;

/// <summary>
/// Interface defining characteristics of Pycnoclavella (genus).
/// </summary>
public interface IPycnoclavella
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

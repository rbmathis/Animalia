namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Phascolarctidae.Phascolarctos;

/// <summary>
/// Interface defining characteristics of Phascolarctos (genus).
/// </summary>
public interface IPhascolarctos
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

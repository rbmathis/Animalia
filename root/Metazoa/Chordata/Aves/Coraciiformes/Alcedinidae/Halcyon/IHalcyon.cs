namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Alcedinidae.Halcyon;

/// <summary>
/// Interface defining characteristics of Halcyon (genus).
/// </summary>
public interface IHalcyon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Chlorostilbon;

/// <summary>
/// Interface defining characteristics of Chlorostilbon (genus).
/// </summary>
public interface IChlorostilbon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

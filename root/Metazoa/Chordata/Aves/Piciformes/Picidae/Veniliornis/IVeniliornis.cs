namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Veniliornis;

/// <summary>
/// Interface defining characteristics of Veniliornis (genus).
/// </summary>
public interface IVeniliornis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

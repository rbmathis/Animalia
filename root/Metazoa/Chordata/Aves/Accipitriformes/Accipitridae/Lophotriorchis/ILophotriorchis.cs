namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Lophotriorchis;

/// <summary>
/// Interface defining characteristics of Lophotriorchis (genus).
/// </summary>
public interface ILophotriorchis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

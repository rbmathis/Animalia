namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passeridae.Philetairus;

/// <summary>
/// Interface defining characteristics of Philetairus (genus).
/// </summary>
public interface IPhiletairus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

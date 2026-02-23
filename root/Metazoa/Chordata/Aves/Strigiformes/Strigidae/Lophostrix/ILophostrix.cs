namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Lophostrix;

/// <summary>
/// Interface defining characteristics of Lophostrix (genus).
/// </summary>
public interface ILophostrix
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

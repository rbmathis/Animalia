namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acanthuriformes.Luvaridae.Luvarus;

/// <summary>
/// Interface defining characteristics of Luvarus (genus).
/// </summary>
public interface ILuvarus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Leucocephalon;

/// <summary>
/// Interface defining characteristics of Leucocephalon (genus).
/// </summary>
public interface ILeucocephalon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

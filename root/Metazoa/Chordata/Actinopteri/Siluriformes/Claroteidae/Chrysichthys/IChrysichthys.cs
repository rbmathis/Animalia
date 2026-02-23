namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Claroteidae.Chrysichthys;

/// <summary>
/// Interface defining characteristics of Chrysichthys (genus).
/// </summary>
public interface IChrysichthys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

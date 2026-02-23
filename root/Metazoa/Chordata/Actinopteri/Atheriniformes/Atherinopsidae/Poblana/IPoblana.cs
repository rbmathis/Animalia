namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinopsidae.Poblana;

/// <summary>
/// Interface defining characteristics of Poblana (genus).
/// </summary>
public interface IPoblana
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

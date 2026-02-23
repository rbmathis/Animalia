namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae.Parviparma;

/// <summary>
/// Interface defining characteristics of Parviparma (genus).
/// </summary>
public interface IParviparma
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

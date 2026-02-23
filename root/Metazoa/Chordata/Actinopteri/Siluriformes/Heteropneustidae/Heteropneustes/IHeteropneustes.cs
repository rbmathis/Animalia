namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heteropneustidae.Heteropneustes;

/// <summary>
/// Interface defining characteristics of Heteropneustes (genus).
/// </summary>
public interface IHeteropneustes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

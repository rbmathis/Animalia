namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Eretmobrycon;

/// <summary>
/// Interface defining characteristics of Eretmobrycon (genus).
/// </summary>
public interface IEretmobrycon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

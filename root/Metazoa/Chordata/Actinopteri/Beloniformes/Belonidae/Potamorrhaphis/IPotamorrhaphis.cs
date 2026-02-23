namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Belonidae.Potamorrhaphis;

/// <summary>
/// Interface defining characteristics of Potamorrhaphis (genus).
/// </summary>
public interface IPotamorrhaphis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

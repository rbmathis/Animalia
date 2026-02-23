namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Amblycipitidae.Amblyceps;

/// <summary>
/// Interface defining characteristics of Amblyceps (genus).
/// </summary>
public interface IAmblyceps
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

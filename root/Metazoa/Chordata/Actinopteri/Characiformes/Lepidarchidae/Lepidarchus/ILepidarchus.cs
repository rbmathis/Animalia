namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Lepidarchidae.Lepidarchus;

/// <summary>
/// Interface defining characteristics of Lepidarchus (genus).
/// </summary>
public interface ILepidarchus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

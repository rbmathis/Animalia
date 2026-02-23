namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Dasyatidae.Urogymnus;

/// <summary>
/// Interface defining characteristics of Urogymnus (genus).
/// </summary>
public interface IUrogymnus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

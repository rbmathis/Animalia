namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae.Protonotaria;

/// <summary>
/// Interface defining characteristics of Protonotaria (genus).
/// </summary>
public interface IProtonotaria
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}

using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae.Protonotaria;

/// <summary>
/// Abstract class for Protonotaria (genus).
/// NCBI TaxId: 182943
/// </summary>
public abstract class Protonotaria : Parulidae, IProtonotaria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Protonotaria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 182943;

    /// <inheritdoc />
    public virtual string GenusName => "Protonotaria";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}

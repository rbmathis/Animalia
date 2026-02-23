using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Psettodidae.Psettodes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Psettodidae.Psettodes.unclassified_Psettodes;

/// <summary>
/// Abstract class for unclassified Psettodes (no rank).
/// NCBI TaxId: 2636692
/// </summary>
public abstract class unclassified_Psettodes : Psettodes, Iunclassified_Psettodes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Psettodes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636692;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Psettodes";
}

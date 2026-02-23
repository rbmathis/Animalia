using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rhinopristiformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rhinopristiformes.unclassified_Pristiformes;

/// <summary>
/// Abstract class for unclassified Pristiformes (no rank).
/// NCBI TaxId: 727669
/// </summary>
public abstract class unclassified_Pristiformes : Rhinopristiformes, Iunclassified_Pristiformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pristiformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 727669;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pristiformes";
}

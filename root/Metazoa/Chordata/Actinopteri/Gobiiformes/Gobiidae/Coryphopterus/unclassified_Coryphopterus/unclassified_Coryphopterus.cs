using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Coryphopterus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Coryphopterus.unclassified_Coryphopterus;

/// <summary>
/// Abstract class for unclassified Coryphopterus (no rank).
/// NCBI TaxId: 2756076
/// </summary>
public abstract class unclassified_Coryphopterus : Coryphopterus, Iunclassified_Coryphopterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Coryphopterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2756076;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Coryphopterus";
}

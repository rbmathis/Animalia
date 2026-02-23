using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pipidae.Xenopus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pipidae.Xenopus.unclassified_Xenopus_in_frogs__toads;

/// <summary>
/// Abstract class for unclassified Xenopus (in: frogs & toads) (no rank).
/// NCBI TaxId: 3407145
/// </summary>
public abstract class unclassified_Xenopus_in_frogs__toads : Xenopus, Iunclassified_Xenopus_in_frogs__toads
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Xenopus (in: frogs & toads)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3407145;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Xenopus_in_frogs__toads";
}

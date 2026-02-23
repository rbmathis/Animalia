using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae.Chiromantis;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae.Chiromantis.unclassified_Chiromantis;

/// <summary>
/// Abstract class for unclassified Chiromantis (no rank).
/// NCBI TaxId: 2622443
/// </summary>
public abstract class unclassified_Chiromantis : Chiromantis, Iunclassified_Chiromantis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chiromantis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2622443;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chiromantis";
}

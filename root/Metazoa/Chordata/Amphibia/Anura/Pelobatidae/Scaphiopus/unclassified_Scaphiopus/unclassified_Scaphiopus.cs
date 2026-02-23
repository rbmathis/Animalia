using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelobatidae.Scaphiopus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelobatidae.Scaphiopus.unclassified_Scaphiopus;

/// <summary>
/// Abstract class for unclassified Scaphiopus (no rank).
/// NCBI TaxId: 2623038
/// </summary>
public abstract class unclassified_Scaphiopus : Scaphiopus, Iunclassified_Scaphiopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Scaphiopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2623038;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Scaphiopus";
}

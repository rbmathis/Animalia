using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Scaphiophryne;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Scaphiophryne.unclassified_Scaphiophryne;

/// <summary>
/// Abstract class for unclassified Scaphiophryne (no rank).
/// NCBI TaxId: 2609370
/// </summary>
public abstract class unclassified_Scaphiophryne : Scaphiophryne, Iunclassified_Scaphiophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Scaphiophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2609370;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Scaphiophryne";
}

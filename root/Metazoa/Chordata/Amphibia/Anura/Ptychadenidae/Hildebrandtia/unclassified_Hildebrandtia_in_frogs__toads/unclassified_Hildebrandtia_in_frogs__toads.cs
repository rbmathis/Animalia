using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ptychadenidae.Hildebrandtia;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ptychadenidae.Hildebrandtia.unclassified_Hildebrandtia_in_frogs__toads;

/// <summary>
/// Abstract class for unclassified Hildebrandtia (in: frogs & toads) (no rank).
/// NCBI TaxId: 2688559
/// </summary>
public abstract class unclassified_Hildebrandtia_in_frogs__toads : Hildebrandtia, Iunclassified_Hildebrandtia_in_frogs__toads
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hildebrandtia (in: frogs & toads)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2688559;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hildebrandtia_in_frogs__toads";
}

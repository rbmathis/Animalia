using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Acanthocercus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Acanthocercus.unclassified_Acanthocercus;

/// <summary>
/// Abstract class for unclassified Acanthocercus (no rank).
/// NCBI TaxId: 2837959
/// </summary>
public abstract class unclassified_Acanthocercus : Acanthocercus, Iunclassified_Acanthocercus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Acanthocercus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2837959;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Acanthocercus";
}

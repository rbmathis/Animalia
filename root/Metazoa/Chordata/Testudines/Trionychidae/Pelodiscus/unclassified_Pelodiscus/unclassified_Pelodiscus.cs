using AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae.Pelodiscus;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae.Pelodiscus.unclassified_Pelodiscus;

/// <summary>
/// Abstract class for unclassified Pelodiscus (no rank).
/// NCBI TaxId: 1472646
/// </summary>
public abstract class unclassified_Pelodiscus : Pelodiscus, Iunclassified_Pelodiscus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pelodiscus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1472646;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pelodiscus";
}

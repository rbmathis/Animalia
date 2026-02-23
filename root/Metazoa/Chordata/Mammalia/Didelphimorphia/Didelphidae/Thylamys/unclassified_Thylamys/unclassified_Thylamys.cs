using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Didelphimorphia.Didelphidae.Thylamys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Didelphimorphia.Didelphidae.Thylamys.unclassified_Thylamys;

/// <summary>
/// Abstract class for unclassified Thylamys (no rank).
/// NCBI TaxId: 2639669
/// </summary>
public abstract class unclassified_Thylamys : Thylamys, Iunclassified_Thylamys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Thylamys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2639669;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Thylamys";
}

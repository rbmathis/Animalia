using AnimalKingdom.root.Metazoa.Chordata.Aves.Trogoniformes.Trogonidae.Apalharpactes;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Trogoniformes.Trogonidae.Apalharpactes.unclassified_Apalharpactes;

/// <summary>
/// Abstract class for unclassified Apalharpactes (no rank).
/// NCBI TaxId: 3443706
/// </summary>
public abstract class unclassified_Apalharpactes : Apalharpactes, Iunclassified_Apalharpactes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Apalharpactes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3443706;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Apalharpactes";
}

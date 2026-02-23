using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Polylepion;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Polylepion.unclassified_Polylepion;

/// <summary>
/// Abstract class for unclassified Polylepion (no rank).
/// NCBI TaxId: 2976166
/// </summary>
public abstract class unclassified_Polylepion : Polylepion, Iunclassified_Polylepion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Polylepion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2976166;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Polylepion";
}

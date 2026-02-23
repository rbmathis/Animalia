using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Sparisoma;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Sparisoma.unclassified_Sparisoma;

/// <summary>
/// Abstract class for unclassified Sparisoma (no rank).
/// NCBI TaxId: 2638648
/// </summary>
public abstract class unclassified_Sparisoma : Sparisoma, Iunclassified_Sparisoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sparisoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2638648;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sparisoma";
}

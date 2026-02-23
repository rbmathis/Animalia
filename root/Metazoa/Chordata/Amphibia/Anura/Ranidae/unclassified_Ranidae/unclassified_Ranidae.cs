using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.unclassified_Ranidae;

/// <summary>
/// Abstract class for unclassified Ranidae (no rank).
/// NCBI TaxId: 685179
/// </summary>
public abstract class unclassified_Ranidae : Ranidae, Iunclassified_Ranidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ranidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 685179;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ranidae";
}

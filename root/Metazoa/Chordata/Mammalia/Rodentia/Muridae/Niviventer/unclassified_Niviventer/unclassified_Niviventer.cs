using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Niviventer;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Niviventer.unclassified_Niviventer;

/// <summary>
/// Abstract class for unclassified Niviventer (no rank).
/// NCBI TaxId: 1003211
/// </summary>
public abstract class unclassified_Niviventer : Niviventer, Iunclassified_Niviventer
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Niviventer";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1003211;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Niviventer";
}

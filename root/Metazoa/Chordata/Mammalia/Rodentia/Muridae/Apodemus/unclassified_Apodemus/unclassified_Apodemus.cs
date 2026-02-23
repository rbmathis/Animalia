using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Apodemus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Apodemus.unclassified_Apodemus;

/// <summary>
/// Abstract class for unclassified Apodemus (no rank).
/// NCBI TaxId: 2684929
/// </summary>
public abstract class unclassified_Apodemus : Apodemus, Iunclassified_Apodemus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Apodemus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2684929;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Apodemus";
}

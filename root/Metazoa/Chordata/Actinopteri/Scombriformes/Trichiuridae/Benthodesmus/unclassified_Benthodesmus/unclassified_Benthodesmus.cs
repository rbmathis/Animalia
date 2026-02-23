using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Trichiuridae.Benthodesmus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Trichiuridae.Benthodesmus.unclassified_Benthodesmus;

/// <summary>
/// Abstract class for unclassified Benthodesmus (no rank).
/// NCBI TaxId: 2630011
/// </summary>
public abstract class unclassified_Benthodesmus : Benthodesmus, Iunclassified_Benthodesmus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Benthodesmus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630011;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Benthodesmus";
}

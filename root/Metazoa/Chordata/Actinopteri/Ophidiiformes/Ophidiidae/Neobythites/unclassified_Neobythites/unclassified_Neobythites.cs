using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Neobythites;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Neobythites.unclassified_Neobythites;

/// <summary>
/// Abstract class for unclassified Neobythites (no rank).
/// NCBI TaxId: 2952362
/// </summary>
public abstract class unclassified_Neobythites : Neobythites, Iunclassified_Neobythites
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Neobythites";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2952362;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Neobythites";
}

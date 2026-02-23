using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Yongeichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Yongeichthys.unclassified_Yongeichthys;

/// <summary>
/// Abstract class for unclassified Yongeichthys (no rank).
/// NCBI TaxId: 3444670
/// </summary>
public abstract class unclassified_Yongeichthys : Yongeichthys, Iunclassified_Yongeichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Yongeichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3444670;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Yongeichthys";
}

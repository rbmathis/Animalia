using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Bythitidae.Ogilbichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Bythitidae.Ogilbichthys.unclassified_Ogilbichthys;

/// <summary>
/// Abstract class for unclassified Ogilbichthys (no rank).
/// NCBI TaxId: 2641597
/// </summary>
public abstract class unclassified_Ogilbichthys : Ogilbichthys, Iunclassified_Ogilbichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ogilbichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641597;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ogilbichthys";
}

using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae.Thysanichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae.Thysanichthys.unclassified_Thysanichthys;

/// <summary>
/// Abstract class for unclassified Thysanichthys (no rank).
/// NCBI TaxId: 2648475
/// </summary>
public abstract class unclassified_Thysanichthys : Thysanichthys, Iunclassified_Thysanichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Thysanichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2648475;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Thysanichthys";
}

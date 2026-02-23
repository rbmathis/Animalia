using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Brittanichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Brittanichthys.unclassified_Brittanichthys;

/// <summary>
/// Abstract class for unclassified Brittanichthys (no rank).
/// NCBI TaxId: 3025594
/// </summary>
public abstract class unclassified_Brittanichthys : Brittanichthys, Iunclassified_Brittanichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Brittanichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3025594;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Brittanichthys";
}

using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Enchelyurus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Enchelyurus.unclassified_Enchelyurus;

/// <summary>
/// Abstract class for unclassified Enchelyurus (no rank).
/// NCBI TaxId: 2645669
/// </summary>
public abstract class unclassified_Enchelyurus : Enchelyurus, Iunclassified_Enchelyurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Enchelyurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2645669;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Enchelyurus";
}

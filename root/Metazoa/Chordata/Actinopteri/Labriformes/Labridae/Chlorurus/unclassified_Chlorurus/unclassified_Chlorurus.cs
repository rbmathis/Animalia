using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Chlorurus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Chlorurus.unclassified_Chlorurus;

/// <summary>
/// Abstract class for unclassified Chlorurus (no rank).
/// NCBI TaxId: 2609510
/// </summary>
public abstract class unclassified_Chlorurus : Chlorurus, Iunclassified_Chlorurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chlorurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2609510;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chlorurus";
}

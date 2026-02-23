using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Paralonchurus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Paralonchurus.unclassified_Paralonchurus;

/// <summary>
/// Abstract class for unclassified Paralonchurus (no rank).
/// NCBI TaxId: 2806154
/// </summary>
public abstract class unclassified_Paralonchurus : Paralonchurus, Iunclassified_Paralonchurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Paralonchurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2806154;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Paralonchurus";
}

using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Setarchidae.Ectreposebastes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Setarchidae.Ectreposebastes.unclassified_Ectreposebastes;

/// <summary>
/// Abstract class for unclassified Ectreposebastes (no rank).
/// NCBI TaxId: 2647103
/// </summary>
public abstract class unclassified_Ectreposebastes : Ectreposebastes, Iunclassified_Ectreposebastes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ectreposebastes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2647103;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ectreposebastes";
}

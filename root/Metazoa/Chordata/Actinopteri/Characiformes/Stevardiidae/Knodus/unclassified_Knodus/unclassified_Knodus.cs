using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Knodus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Knodus.unclassified_Knodus;

/// <summary>
/// Abstract class for unclassified Knodus (no rank).
/// NCBI TaxId: 2630806
/// </summary>
public abstract class unclassified_Knodus : Knodus, Iunclassified_Knodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Knodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630806;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Knodus";
}

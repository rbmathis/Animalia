using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae.Pimelodus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae.Pimelodus.unclassified_Pimelodus;

/// <summary>
/// Abstract class for unclassified Pimelodus (no rank).
/// NCBI TaxId: 2602678
/// </summary>
public abstract class unclassified_Pimelodus : Pimelodus, Iunclassified_Pimelodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pimelodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2602678;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pimelodus";
}

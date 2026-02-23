using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Chilodontidae.Chilodus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Chilodontidae.Chilodus.unclassified_Chilodus;

/// <summary>
/// Abstract class for unclassified Chilodus (no rank).
/// NCBI TaxId: 2618266
/// </summary>
public abstract class unclassified_Chilodus : Chilodus, Iunclassified_Chilodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chilodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2618266;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chilodus";
}

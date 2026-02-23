using AnimalKingdom.root.Metazoa.Chordata.Ceratodontiformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Ceratodontiformes.unclassified_Lepidosireniformes;

/// <summary>
/// Abstract class for unclassified Lepidosireniformes (no rank).
/// NCBI TaxId: 891962
/// </summary>
public abstract class unclassified_Lepidosireniformes : Ceratodontiformes, Iunclassified_Lepidosireniformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lepidosireniformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 891962;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lepidosireniformes";
}

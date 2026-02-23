using AnimalKingdom.root.Metazoa.Chordata.Ceratodontiformes.Lepidosirenidae.Lepidosiren;

namespace AnimalKingdom.root.Metazoa.Chordata.Ceratodontiformes.Lepidosirenidae.Lepidosiren.unclassified_Lepidosiren;

/// <summary>
/// Abstract class for unclassified Lepidosiren (no rank).
/// NCBI TaxId: 2649936
/// </summary>
public abstract class unclassified_Lepidosiren : Lepidosiren, Iunclassified_Lepidosiren
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lepidosiren";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2649936;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lepidosiren";
}

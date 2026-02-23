using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Sarada;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Sarada.unclassified_Sarada;

/// <summary>
/// Abstract class for unclassified Sarada (no rank).
/// NCBI TaxId: 2636268
/// </summary>
public abstract class unclassified_Sarada : Sarada, Iunclassified_Sarada
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sarada";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636268;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sarada";
}

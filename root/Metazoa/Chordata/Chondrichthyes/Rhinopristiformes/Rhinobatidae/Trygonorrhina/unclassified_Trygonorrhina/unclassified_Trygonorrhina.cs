using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rhinopristiformes.Rhinobatidae.Trygonorrhina;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rhinopristiformes.Rhinobatidae.Trygonorrhina.unclassified_Trygonorrhina;

/// <summary>
/// Abstract class for unclassified Trygonorrhina (no rank).
/// NCBI TaxId: 2630251
/// </summary>
public abstract class unclassified_Trygonorrhina : Trygonorrhina, Iunclassified_Trygonorrhina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Trygonorrhina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630251;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Trygonorrhina";
}

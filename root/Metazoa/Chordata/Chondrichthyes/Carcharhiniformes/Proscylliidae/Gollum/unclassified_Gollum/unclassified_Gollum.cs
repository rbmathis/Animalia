using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Proscylliidae.Gollum;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Proscylliidae.Gollum.unclassified_Gollum;

/// <summary>
/// Abstract class for unclassified Gollum (no rank).
/// NCBI TaxId: 2644894
/// </summary>
public abstract class unclassified_Gollum : Gollum, Iunclassified_Gollum
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gollum";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644894;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gollum";
}

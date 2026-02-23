using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Proscylliidae.Eridacnis;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Proscylliidae.Eridacnis.unclassified_Eridacnis;

/// <summary>
/// Abstract class for unclassified Eridacnis (no rank).
/// NCBI TaxId: 2644196
/// </summary>
public abstract class unclassified_Eridacnis : Eridacnis, Iunclassified_Eridacnis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Eridacnis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644196;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Eridacnis";
}

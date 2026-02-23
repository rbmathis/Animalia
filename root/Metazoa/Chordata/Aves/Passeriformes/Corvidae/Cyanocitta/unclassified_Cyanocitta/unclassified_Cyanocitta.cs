using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Cyanocitta;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Cyanocitta.unclassified_Cyanocitta;

/// <summary>
/// Abstract class for unclassified Cyanocitta (no rank).
/// NCBI TaxId: 2878421
/// </summary>
public abstract class unclassified_Cyanocitta : Cyanocitta, Iunclassified_Cyanocitta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cyanocitta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2878421;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cyanocitta";
}

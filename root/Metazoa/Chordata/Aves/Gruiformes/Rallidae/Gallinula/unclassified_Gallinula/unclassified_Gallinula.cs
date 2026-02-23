using AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Gallinula;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Gallinula.unclassified_Gallinula;

/// <summary>
/// Abstract class for unclassified Gallinula (no rank).
/// NCBI TaxId: 2935792
/// </summary>
public abstract class unclassified_Gallinula : Gallinula, Iunclassified_Gallinula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gallinula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2935792;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gallinula";
}

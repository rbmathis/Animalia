using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Kerivoula;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Kerivoula.unclassified_Kerivoula;

/// <summary>
/// Abstract class for unclassified Kerivoula (no rank).
/// NCBI TaxId: 2618055
/// </summary>
public abstract class unclassified_Kerivoula : Kerivoula, Iunclassified_Kerivoula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Kerivoula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2618055;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Kerivoula";
}

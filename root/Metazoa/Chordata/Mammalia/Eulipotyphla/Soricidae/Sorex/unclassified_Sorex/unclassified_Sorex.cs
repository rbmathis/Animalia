using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Sorex;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Sorex.unclassified_Sorex;

/// <summary>
/// Abstract class for unclassified Sorex (no rank).
/// NCBI TaxId: 2626901
/// </summary>
public abstract class unclassified_Sorex : Sorex, Iunclassified_Sorex
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sorex";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626901;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sorex";
}

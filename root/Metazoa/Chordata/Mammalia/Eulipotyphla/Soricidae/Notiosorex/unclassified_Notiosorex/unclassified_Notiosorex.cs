using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Notiosorex;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Notiosorex.unclassified_Notiosorex;

/// <summary>
/// Abstract class for unclassified Notiosorex (no rank).
/// NCBI TaxId: 2716166
/// </summary>
public abstract class unclassified_Notiosorex : Notiosorex, Iunclassified_Notiosorex
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Notiosorex";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2716166;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Notiosorex";
}

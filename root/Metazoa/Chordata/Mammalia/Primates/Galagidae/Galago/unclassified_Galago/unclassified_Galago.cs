using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Galagidae.Galago;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Galagidae.Galago.unclassified_Galago;

/// <summary>
/// Abstract class for unclassified Galago (no rank).
/// NCBI TaxId: 2628747
/// </summary>
public abstract class unclassified_Galago : Galago, Iunclassified_Galago
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Galago";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2628747;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Galago";
}

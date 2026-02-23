using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Lemuridae.Lemur;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Lemuridae.Lemur.unclassified_Lemur;

/// <summary>
/// Abstract class for unclassified Lemur (no rank).
/// NCBI TaxId: 2641939
/// </summary>
public abstract class unclassified_Lemur : Lemur, Iunclassified_Lemur
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lemur";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641939;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lemur";
}

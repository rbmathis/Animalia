using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae.Neocentropogon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae.Neocentropogon.unclassified_Neocentropogon;

/// <summary>
/// Abstract class for unclassified Neocentropogon (no rank).
/// NCBI TaxId: 2634053
/// </summary>
public abstract class unclassified_Neocentropogon : Neocentropogon, Iunclassified_Neocentropogon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Neocentropogon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634053;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Neocentropogon";
}

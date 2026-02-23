using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Gymnapogon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Gymnapogon.unclassified_Gymnapogon;

/// <summary>
/// Abstract class for unclassified Gymnapogon (no rank).
/// NCBI TaxId: 2626638
/// </summary>
public abstract class unclassified_Gymnapogon : Gymnapogon, Iunclassified_Gymnapogon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gymnapogon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626638;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gymnapogon";
}

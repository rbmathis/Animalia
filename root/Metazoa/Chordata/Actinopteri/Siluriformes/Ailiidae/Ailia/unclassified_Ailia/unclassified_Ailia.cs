using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ailiidae.Ailia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ailiidae.Ailia.unclassified_Ailia;

/// <summary>
/// Abstract class for unclassified Ailia (no rank).
/// NCBI TaxId: 2645346
/// </summary>
public abstract class unclassified_Ailia : Ailia, Iunclassified_Ailia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ailia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2645346;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ailia";
}

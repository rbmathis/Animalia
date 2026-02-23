using AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Elseya;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Elseya.unclassified_Elseya;

/// <summary>
/// Abstract class for unclassified Elseya (no rank).
/// NCBI TaxId: 2632634
/// </summary>
public abstract class unclassified_Elseya : Elseya, Iunclassified_Elseya
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Elseya";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2632634;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Elseya";
}

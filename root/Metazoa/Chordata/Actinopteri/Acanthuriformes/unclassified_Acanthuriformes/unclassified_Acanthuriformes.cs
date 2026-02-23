using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acanthuriformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acanthuriformes.unclassified_Acanthuriformes;

/// <summary>
/// Abstract class for unclassified Acanthuriformes (no rank).
/// NCBI TaxId: 2107280
/// </summary>
public abstract class unclassified_Acanthuriformes : Acanthuriformes, Iunclassified_Acanthuriformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Acanthuriformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2107280;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Acanthuriformes";
}

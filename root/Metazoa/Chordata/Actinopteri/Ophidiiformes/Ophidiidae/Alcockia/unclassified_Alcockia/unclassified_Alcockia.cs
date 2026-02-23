using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Alcockia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Alcockia.unclassified_Alcockia;

/// <summary>
/// Abstract class for unclassified Alcockia (no rank).
/// NCBI TaxId: 3456049
/// </summary>
public abstract class unclassified_Alcockia : Alcockia, Iunclassified_Alcockia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Alcockia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3456049;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Alcockia";
}

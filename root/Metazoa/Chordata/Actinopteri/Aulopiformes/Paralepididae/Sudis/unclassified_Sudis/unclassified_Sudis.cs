using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Paralepididae.Sudis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Paralepididae.Sudis.unclassified_Sudis;

/// <summary>
/// Abstract class for unclassified Sudis (no rank).
/// NCBI TaxId: 2637844
/// </summary>
public abstract class unclassified_Sudis : Sudis, Iunclassified_Sudis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sudis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2637844;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sudis";
}

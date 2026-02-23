using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Serrivomeridae.Serrivomer;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Serrivomeridae.Serrivomer.unclassified_Serrivomer;

/// <summary>
/// Abstract class for unclassified Serrivomer (no rank).
/// NCBI TaxId: 2648585
/// </summary>
public abstract class unclassified_Serrivomer : Serrivomer, Iunclassified_Serrivomer
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Serrivomer";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2648585;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Serrivomer";
}

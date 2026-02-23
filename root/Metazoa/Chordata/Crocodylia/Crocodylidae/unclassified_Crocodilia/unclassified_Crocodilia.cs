using AnimalKingdom.root.Metazoa.Chordata.Crocodylia.Crocodylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Crocodylia.Crocodylidae.unclassified_Crocodilia;

/// <summary>
/// Abstract class for unclassified Crocodilia (no rank).
/// NCBI TaxId: 1067855
/// </summary>
public abstract class unclassified_Crocodilia : Crocodylidae, Iunclassified_Crocodilia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Crocodilia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1067855;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Crocodilia";
}

using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Torpediniformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Torpediniformes.unclassified_Torpediniformes;

/// <summary>
/// Abstract class for unclassified Torpediniformes (no rank).
/// NCBI TaxId: 727674
/// </summary>
public abstract class unclassified_Torpediniformes : Torpediniformes, Iunclassified_Torpediniformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Torpediniformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 727674;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Torpediniformes";
}

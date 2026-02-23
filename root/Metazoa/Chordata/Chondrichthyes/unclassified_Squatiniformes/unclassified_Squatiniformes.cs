using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.unclassified_Squatiniformes;

/// <summary>
/// Abstract class for unclassified Squatiniformes (no rank).
/// NCBI TaxId: 727671
/// </summary>
public abstract class unclassified_Squatiniformes : Chondrichthyes, Iunclassified_Squatiniformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Squatiniformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 727671;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Squatiniformes";
}

using AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.unclassified_Columbiformes;

/// <summary>
/// Abstract class for unclassified Columbiformes (no rank).
/// NCBI TaxId: 791187
/// </summary>
public abstract class unclassified_Columbiformes : Columbiformes, Iunclassified_Columbiformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Columbiformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 791187;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Columbiformes";
}

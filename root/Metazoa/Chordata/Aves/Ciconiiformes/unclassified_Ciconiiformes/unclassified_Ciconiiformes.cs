using AnimalKingdom.root.Metazoa.Chordata.Aves.Ciconiiformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Ciconiiformes.unclassified_Ciconiiformes;

/// <summary>
/// Abstract class for unclassified Ciconiiformes (no rank).
/// NCBI TaxId: 791185
/// </summary>
public abstract class unclassified_Ciconiiformes : Ciconiiformes, Iunclassified_Ciconiiformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ciconiiformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 791185;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ciconiiformes";
}

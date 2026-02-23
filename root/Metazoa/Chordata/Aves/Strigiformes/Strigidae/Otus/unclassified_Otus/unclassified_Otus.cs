using AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Otus;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Otus.unclassified_Otus;

/// <summary>
/// Abstract class for unclassified Otus (no rank).
/// NCBI TaxId: 2620078
/// </summary>
public abstract class unclassified_Otus : Otus, Iunclassified_Otus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Otus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620078;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Otus";
}

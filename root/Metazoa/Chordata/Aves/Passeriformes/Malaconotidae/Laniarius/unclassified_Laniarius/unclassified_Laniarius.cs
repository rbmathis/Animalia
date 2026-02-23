using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Malaconotidae.Laniarius;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Malaconotidae.Laniarius.unclassified_Laniarius;

/// <summary>
/// Abstract class for unclassified Laniarius (no rank).
/// NCBI TaxId: 2640430
/// </summary>
public abstract class unclassified_Laniarius : Laniarius, Iunclassified_Laniarius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Laniarius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640430;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Laniarius";
}

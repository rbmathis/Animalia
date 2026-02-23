using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Synanceiidae.Synanceia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Synanceiidae.Synanceia.unclassified_Synanceia;

/// <summary>
/// Abstract class for unclassified Synanceia (no rank).
/// NCBI TaxId: 2632421
/// </summary>
public abstract class unclassified_Synanceia : Synanceia, Iunclassified_Synanceia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Synanceia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2632421;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Synanceia";
}

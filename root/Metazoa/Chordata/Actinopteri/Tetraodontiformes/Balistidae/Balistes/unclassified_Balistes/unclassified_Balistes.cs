using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Balistidae.Balistes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Balistidae.Balistes.unclassified_Balistes;

/// <summary>
/// Abstract class for unclassified Balistes (no rank).
/// NCBI TaxId: 2642541
/// </summary>
public abstract class unclassified_Balistes : Balistes, Iunclassified_Balistes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Balistes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2642541;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Balistes";
}

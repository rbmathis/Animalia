using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Trachinidae.Trachinus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Trachinidae.Trachinus.unclassified_Trachinus;

/// <summary>
/// Abstract class for unclassified Trachinus (no rank).
/// NCBI TaxId: 3453844
/// </summary>
public abstract class unclassified_Trachinus : Trachinus, Iunclassified_Trachinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Trachinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3453844;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Trachinus";
}

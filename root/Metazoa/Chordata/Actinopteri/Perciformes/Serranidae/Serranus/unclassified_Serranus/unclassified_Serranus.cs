using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Serranus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Serranus.unclassified_Serranus;

/// <summary>
/// Abstract class for unclassified Serranus (no rank).
/// NCBI TaxId: 2628371
/// </summary>
public abstract class unclassified_Serranus : Serranus, Iunclassified_Serranus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Serranus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2628371;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Serranus";
}

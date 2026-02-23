using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Platycephalidae.Rogadius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Platycephalidae.Rogadius.unclassified_Rogadius;

/// <summary>
/// Abstract class for unclassified Rogadius (no rank).
/// NCBI TaxId: 2650305
/// </summary>
public abstract class unclassified_Rogadius : Rogadius, Iunclassified_Rogadius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rogadius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2650305;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rogadius";
}

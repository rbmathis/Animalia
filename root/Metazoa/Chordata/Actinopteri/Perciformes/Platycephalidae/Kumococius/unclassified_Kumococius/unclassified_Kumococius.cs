using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Platycephalidae.Kumococius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Platycephalidae.Kumococius.unclassified_Kumococius;

/// <summary>
/// Abstract class for unclassified Kumococius (no rank).
/// NCBI TaxId: 2650292
/// </summary>
public abstract class unclassified_Kumococius : Kumococius, Iunclassified_Kumococius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Kumococius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2650292;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Kumococius";
}

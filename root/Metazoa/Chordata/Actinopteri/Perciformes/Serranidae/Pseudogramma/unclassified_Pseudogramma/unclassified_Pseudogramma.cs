using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Pseudogramma;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Pseudogramma.unclassified_Pseudogramma;

/// <summary>
/// Abstract class for unclassified Pseudogramma (no rank).
/// NCBI TaxId: 2648820
/// </summary>
public abstract class unclassified_Pseudogramma : Pseudogramma, Iunclassified_Pseudogramma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pseudogramma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2648820;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pseudogramma";
}

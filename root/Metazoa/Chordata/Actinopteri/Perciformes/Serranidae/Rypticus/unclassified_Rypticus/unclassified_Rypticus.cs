using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Rypticus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Rypticus.unclassified_Rypticus;

/// <summary>
/// Abstract class for unclassified Rypticus (no rank).
/// NCBI TaxId: 2639447
/// </summary>
public abstract class unclassified_Rypticus : Rypticus, Iunclassified_Rypticus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rypticus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2639447;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rypticus";
}

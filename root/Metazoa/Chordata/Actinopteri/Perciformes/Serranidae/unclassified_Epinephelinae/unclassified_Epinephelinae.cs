using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.unclassified_Epinephelinae;

/// <summary>
/// Abstract class for unclassified Epinephelinae (no rank).
/// NCBI TaxId: 338894
/// </summary>
public abstract class unclassified_Epinephelinae : Serranidae, Iunclassified_Epinephelinae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Epinephelinae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 338894;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Epinephelinae";
}

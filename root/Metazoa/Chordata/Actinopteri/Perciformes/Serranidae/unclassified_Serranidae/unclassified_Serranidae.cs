using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.unclassified_Serranidae;

/// <summary>
/// Abstract class for unclassified Serranidae (no rank).
/// NCBI TaxId: 1182108
/// </summary>
public abstract class unclassified_Serranidae : Serranidae, Iunclassified_Serranidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Serranidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1182108;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Serranidae";
}

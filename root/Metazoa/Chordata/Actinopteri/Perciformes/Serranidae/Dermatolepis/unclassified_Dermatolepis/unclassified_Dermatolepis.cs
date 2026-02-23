using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Dermatolepis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Dermatolepis.unclassified_Dermatolepis;

/// <summary>
/// Abstract class for unclassified Dermatolepis (no rank).
/// NCBI TaxId: 2626251
/// </summary>
public abstract class unclassified_Dermatolepis : Dermatolepis, Iunclassified_Dermatolepis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dermatolepis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626251;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dermatolepis";
}

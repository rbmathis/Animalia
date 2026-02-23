using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae.Andriashevia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae.Andriashevia.unclassified_Andriashevia;

/// <summary>
/// Abstract class for unclassified Andriashevia (no rank).
/// NCBI TaxId: 2627609
/// </summary>
public abstract class unclassified_Andriashevia : Andriashevia, Iunclassified_Andriashevia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Andriashevia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2627609;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Andriashevia";
}

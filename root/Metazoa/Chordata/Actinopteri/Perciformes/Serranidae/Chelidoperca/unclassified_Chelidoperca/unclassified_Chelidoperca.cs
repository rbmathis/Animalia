using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Chelidoperca;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Chelidoperca.unclassified_Chelidoperca;

/// <summary>
/// Abstract class for unclassified Chelidoperca (no rank).
/// NCBI TaxId: 2619114
/// </summary>
public abstract class unclassified_Chelidoperca : Chelidoperca, Iunclassified_Chelidoperca
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chelidoperca";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619114;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chelidoperca";
}

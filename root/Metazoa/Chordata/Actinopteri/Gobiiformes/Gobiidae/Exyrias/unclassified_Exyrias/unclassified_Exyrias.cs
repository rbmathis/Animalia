using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Exyrias;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Exyrias.unclassified_Exyrias;

/// <summary>
/// Abstract class for unclassified Exyrias (no rank).
/// NCBI TaxId: 3446856
/// </summary>
public abstract class unclassified_Exyrias : Exyrias, Iunclassified_Exyrias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Exyrias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3446856;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Exyrias";
}

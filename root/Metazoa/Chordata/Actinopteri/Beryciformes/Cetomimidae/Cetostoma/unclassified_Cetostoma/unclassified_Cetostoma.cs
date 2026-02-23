using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Cetomimidae.Cetostoma;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Cetomimidae.Cetostoma.unclassified_Cetostoma;

/// <summary>
/// Abstract class for unclassified Cetostoma (no rank).
/// NCBI TaxId: 2642625
/// </summary>
public abstract class unclassified_Cetostoma : Cetostoma, Iunclassified_Cetostoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cetostoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2642625;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cetostoma";
}

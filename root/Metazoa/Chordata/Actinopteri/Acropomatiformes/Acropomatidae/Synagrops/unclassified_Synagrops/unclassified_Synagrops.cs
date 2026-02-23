using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Acropomatidae.Synagrops;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Acropomatidae.Synagrops.unclassified_Synagrops;

/// <summary>
/// Abstract class for unclassified Synagrops (no rank).
/// NCBI TaxId: 2890339
/// </summary>
public abstract class unclassified_Synagrops : Synagrops, Iunclassified_Synagrops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Synagrops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2890339;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Synagrops";
}

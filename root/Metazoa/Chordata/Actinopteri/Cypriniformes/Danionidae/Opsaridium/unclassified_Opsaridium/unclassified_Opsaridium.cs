using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Opsaridium;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Opsaridium.unclassified_Opsaridium;

/// <summary>
/// Abstract class for unclassified Opsaridium (no rank).
/// NCBI TaxId: 2621601
/// </summary>
public abstract class unclassified_Opsaridium : Opsaridium, Iunclassified_Opsaridium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Opsaridium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621601;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Opsaridium";
}

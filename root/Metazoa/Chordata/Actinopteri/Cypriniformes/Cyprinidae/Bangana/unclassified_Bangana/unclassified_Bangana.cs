using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Bangana;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Bangana.unclassified_Bangana;

/// <summary>
/// Abstract class for unclassified Bangana (no rank).
/// NCBI TaxId: 2647342
/// </summary>
public abstract class unclassified_Bangana : Bangana, Iunclassified_Bangana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bangana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2647342;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bangana";
}

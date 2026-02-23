using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ceratobatrachidae.Cornufer;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ceratobatrachidae.Cornufer.unclassified_Cornufer;

/// <summary>
/// Abstract class for unclassified Cornufer (no rank).
/// NCBI TaxId: 2627842
/// </summary>
public abstract class unclassified_Cornufer : Cornufer, Iunclassified_Cornufer
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cornufer";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2627842;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cornufer";
}

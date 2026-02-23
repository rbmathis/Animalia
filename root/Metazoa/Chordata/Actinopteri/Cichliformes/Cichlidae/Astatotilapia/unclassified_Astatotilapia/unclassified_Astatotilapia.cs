using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Astatotilapia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Astatotilapia.unclassified_Astatotilapia;

/// <summary>
/// Abstract class for unclassified Astatotilapia (no rank).
/// NCBI TaxId: 2609039
/// </summary>
public abstract class unclassified_Astatotilapia : Astatotilapia, Iunclassified_Astatotilapia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Astatotilapia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2609039;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Astatotilapia";
}

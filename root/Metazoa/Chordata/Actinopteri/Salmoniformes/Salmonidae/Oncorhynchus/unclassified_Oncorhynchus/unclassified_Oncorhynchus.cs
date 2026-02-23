using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae.Oncorhynchus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae.Oncorhynchus.unclassified_Oncorhynchus;

/// <summary>
/// Abstract class for unclassified Oncorhynchus (no rank).
/// NCBI TaxId: 2622843
/// </summary>
public abstract class unclassified_Oncorhynchus : Oncorhynchus, Iunclassified_Oncorhynchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Oncorhynchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2622843;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Oncorhynchus";
}

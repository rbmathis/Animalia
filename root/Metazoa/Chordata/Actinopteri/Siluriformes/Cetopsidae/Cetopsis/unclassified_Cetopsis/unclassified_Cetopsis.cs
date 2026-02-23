using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Cetopsidae.Cetopsis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Cetopsidae.Cetopsis.unclassified_Cetopsis;

/// <summary>
/// Abstract class for unclassified Cetopsis (no rank).
/// NCBI TaxId: 2644712
/// </summary>
public abstract class unclassified_Cetopsis : Cetopsis, Iunclassified_Cetopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cetopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644712;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cetopsis";
}

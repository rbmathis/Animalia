using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Cetopsidae.Cetopsidium;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Cetopsidae.Cetopsidium.unclassified_Cetopsidium;

/// <summary>
/// Abstract class for unclassified Cetopsidium (no rank).
/// NCBI TaxId: 2623384
/// </summary>
public abstract class unclassified_Cetopsidium : Cetopsidium, Iunclassified_Cetopsidium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cetopsidium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2623384;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cetopsidium";
}

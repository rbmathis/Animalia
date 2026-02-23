using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Cetopsidae.Pseudocetopsis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Cetopsidae.Pseudocetopsis.unclassified_Pseudocetopsis;

/// <summary>
/// Abstract class for unclassified Pseudocetopsis (no rank).
/// NCBI TaxId: 2640873
/// </summary>
public abstract class unclassified_Pseudocetopsis : Pseudocetopsis, Iunclassified_Pseudocetopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pseudocetopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640873;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pseudocetopsis";
}

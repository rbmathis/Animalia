using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Carangoides;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Carangoides.unclassified_Carangoides;

/// <summary>
/// Abstract class for unclassified Carangoides (no rank).
/// NCBI TaxId: 2628752
/// </summary>
public abstract class unclassified_Carangoides : Carangoides, Iunclassified_Carangoides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Carangoides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2628752;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Carangoides";
}

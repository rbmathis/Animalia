using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.unclassified_Carangidae;

/// <summary>
/// Abstract class for unclassified Carangidae (no rank).
/// NCBI TaxId: 909098
/// </summary>
public abstract class unclassified_Carangidae : Carangidae, Iunclassified_Carangidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Carangidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 909098;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Carangidae";
}

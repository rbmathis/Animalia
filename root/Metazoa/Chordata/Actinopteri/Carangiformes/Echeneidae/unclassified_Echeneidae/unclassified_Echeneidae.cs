using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Echeneidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Echeneidae.unclassified_Echeneidae;

/// <summary>
/// Abstract class for unclassified Echeneidae (no rank).
/// NCBI TaxId: 1963629
/// </summary>
public abstract class unclassified_Echeneidae : Echeneidae, Iunclassified_Echeneidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Echeneidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1963629;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Echeneidae";
}

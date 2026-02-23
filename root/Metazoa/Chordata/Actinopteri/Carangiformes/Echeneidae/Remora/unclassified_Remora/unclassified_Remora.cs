using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Echeneidae.Remora;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Echeneidae.Remora.unclassified_Remora;

/// <summary>
/// Abstract class for unclassified Remora (no rank).
/// NCBI TaxId: 3444692
/// </summary>
public abstract class unclassified_Remora : Remora, Iunclassified_Remora
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Remora";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3444692;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Remora";
}

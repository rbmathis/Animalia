using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cobitidae.Pangio;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cobitidae.Pangio.unclassified_Pangio;

/// <summary>
/// Abstract class for unclassified Pangio (no rank).
/// NCBI TaxId: 2635185
/// </summary>
public abstract class unclassified_Pangio : Pangio, Iunclassified_Pangio
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pangio";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2635185;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pangio";
}

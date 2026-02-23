using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Caproiformes.Caproidae.Antigonia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Caproiformes.Caproidae.Antigonia.unclassified_Antigonia;

/// <summary>
/// Abstract class for unclassified Antigonia (no rank).
/// NCBI TaxId: 2649438
/// </summary>
public abstract class unclassified_Antigonia : Antigonia, Iunclassified_Antigonia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Antigonia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2649438;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Antigonia";
}

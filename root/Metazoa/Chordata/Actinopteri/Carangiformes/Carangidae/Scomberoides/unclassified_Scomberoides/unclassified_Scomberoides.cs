using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Scomberoides;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Scomberoides.unclassified_Scomberoides;

/// <summary>
/// Abstract class for unclassified Scomberoides (no rank).
/// NCBI TaxId: 2625717
/// </summary>
public abstract class unclassified_Scomberoides : Scomberoides, Iunclassified_Scomberoides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Scomberoides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2625717;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Scomberoides";
}

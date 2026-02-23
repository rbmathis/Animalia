using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pilosa.Mylodontidae.Scelidodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pilosa.Mylodontidae.Scelidodon.unclassified_Scelidodon;

/// <summary>
/// Abstract class for unclassified Scelidodon (no rank).
/// NCBI TaxId: 2639064
/// </summary>
public abstract class unclassified_Scelidodon : Scelidodon, Iunclassified_Scelidodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Scelidodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2639064;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Scelidodon";
}

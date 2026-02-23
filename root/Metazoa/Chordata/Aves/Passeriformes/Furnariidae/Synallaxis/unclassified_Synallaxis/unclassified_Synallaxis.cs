using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Synallaxis;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Synallaxis.unclassified_Synallaxis;

/// <summary>
/// Abstract class for unclassified Synallaxis (no rank).
/// NCBI TaxId: 2636136
/// </summary>
public abstract class unclassified_Synallaxis : Synallaxis, Iunclassified_Synallaxis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Synallaxis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636136;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Synallaxis";
}

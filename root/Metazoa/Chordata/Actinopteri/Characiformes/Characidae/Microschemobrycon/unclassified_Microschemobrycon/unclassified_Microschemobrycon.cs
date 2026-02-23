using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Microschemobrycon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Microschemobrycon.unclassified_Microschemobrycon;

/// <summary>
/// Abstract class for unclassified Microschemobrycon (no rank).
/// NCBI TaxId: 2626950
/// </summary>
public abstract class unclassified_Microschemobrycon : Microschemobrycon, Iunclassified_Microschemobrycon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Microschemobrycon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626950;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Microschemobrycon";
}

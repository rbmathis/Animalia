using AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Procellariidae.Ardenna;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Procellariidae.Ardenna.unclassified_Ardenna;

/// <summary>
/// Abstract class for unclassified Ardenna (no rank).
/// NCBI TaxId: 2636929
/// </summary>
public abstract class unclassified_Ardenna : Ardenna, Iunclassified_Ardenna
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ardenna";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636929;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ardenna";
}

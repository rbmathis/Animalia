using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Paucituberculata.Caenolestidae.Caenolestes;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Paucituberculata.Caenolestidae.Caenolestes.unclassified_Caenolestes;

/// <summary>
/// Abstract class for unclassified Caenolestes (no rank).
/// NCBI TaxId: 2964406
/// </summary>
public abstract class unclassified_Caenolestes : Caenolestes, Iunclassified_Caenolestes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Caenolestes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2964406;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Caenolestes";
}

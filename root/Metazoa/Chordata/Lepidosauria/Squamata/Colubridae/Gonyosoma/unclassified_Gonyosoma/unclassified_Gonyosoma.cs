using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Gonyosoma;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Gonyosoma.unclassified_Gonyosoma;

/// <summary>
/// Abstract class for unclassified Gonyosoma (no rank).
/// NCBI TaxId: 2918892
/// </summary>
public abstract class unclassified_Gonyosoma : Gonyosoma, Iunclassified_Gonyosoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gonyosoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2918892;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gonyosoma";
}

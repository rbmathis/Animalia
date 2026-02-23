using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Pachypops;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Pachypops.unclassified_Pachypops;

/// <summary>
/// Abstract class for unclassified Pachypops (no rank).
/// NCBI TaxId: 2621864
/// </summary>
public abstract class unclassified_Pachypops : Pachypops, Iunclassified_Pachypops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pachypops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621864;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pachypops";
}

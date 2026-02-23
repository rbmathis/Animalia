using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Crotalus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Crotalus.unclassified_Crotalus;

/// <summary>
/// Abstract class for unclassified Crotalus (no rank).
/// NCBI TaxId: 2677136
/// </summary>
public abstract class unclassified_Crotalus : Crotalus, Iunclassified_Crotalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Crotalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2677136;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Crotalus";
}

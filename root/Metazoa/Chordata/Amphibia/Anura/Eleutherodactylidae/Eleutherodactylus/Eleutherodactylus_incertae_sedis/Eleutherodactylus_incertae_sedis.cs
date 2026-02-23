using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Eleutherodactylidae.Eleutherodactylus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Eleutherodactylidae.Eleutherodactylus.Eleutherodactylus_incertae_sedis;

/// <summary>
/// Abstract class for Eleutherodactylus incertae sedis (no rank).
/// NCBI TaxId: 449731
/// </summary>
public abstract class Eleutherodactylus_incertae_sedis : Eleutherodactylus, IEleutherodactylus_incertae_sedis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eleutherodactylus incertae sedis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 449731;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Eleutherodactylus_incertae_sedis";
}

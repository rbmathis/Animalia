using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Microhylidae_incertae_sedis;

/// <summary>
/// Abstract class for Microhylidae incertae sedis (no rank).
/// NCBI TaxId: 980592
/// </summary>
public abstract class Microhylidae_incertae_sedis : Microhylidae, IMicrohylidae_incertae_sedis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Microhylidae incertae sedis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 980592;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Microhylidae_incertae_sedis";
}

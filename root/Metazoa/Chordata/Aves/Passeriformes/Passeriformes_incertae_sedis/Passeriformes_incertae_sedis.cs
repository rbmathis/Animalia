using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passeriformes_incertae_sedis;

/// <summary>
/// Abstract class for Passeriformes incertae sedis (no rank).
/// NCBI TaxId: 634316
/// </summary>
public abstract class Passeriformes_incertae_sedis : Passeriformes, IPasseriformes_incertae_sedis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Passeriformes incertae sedis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 634316;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Passeriformes_incertae_sedis";
}

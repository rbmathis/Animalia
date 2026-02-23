using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathiformes_incertae_sedis;

/// <summary>
/// Abstract class for Syngnathiformes incertae sedis (no rank).
/// NCBI TaxId: 1489888
/// </summary>
public abstract class Syngnathiformes_incertae_sedis : Syngnathiformes, ISyngnathiformes_incertae_sedis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Syngnathiformes incertae sedis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1489888;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Syngnathiformes_incertae_sedis";
}

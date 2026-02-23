using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Muridae_incertae_sedis;

/// <summary>
/// Abstract class for Muridae incertae sedis (no rank).
/// NCBI TaxId: 2927072
/// </summary>
public abstract class Muridae_incertae_sedis : Muridae, IMuridae_incertae_sedis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Muridae incertae sedis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2927072;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Muridae_incertae_sedis";
}

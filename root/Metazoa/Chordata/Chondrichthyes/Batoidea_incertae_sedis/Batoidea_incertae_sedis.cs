using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Batoidea_incertae_sedis;

/// <summary>
/// Abstract class for Batoidea incertae sedis (no rank).
/// NCBI TaxId: 1158977
/// </summary>
public abstract class Batoidea_incertae_sedis : Chondrichthyes, IBatoidea_incertae_sedis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Batoidea incertae sedis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1158977;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Batoidea_incertae_sedis";
}

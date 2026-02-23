using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Apogon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Apogon.Apogon_incertae_sedis;

/// <summary>
/// Abstract class for Apogon incertae sedis (no rank).
/// NCBI TaxId: 2579140
/// </summary>
public abstract class Apogon_incertae_sedis : Apogon, IApogon_incertae_sedis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Apogon incertae sedis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2579140;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Apogon_incertae_sedis";
}

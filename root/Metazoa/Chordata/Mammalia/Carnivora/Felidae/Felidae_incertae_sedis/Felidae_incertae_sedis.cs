using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Felidae_incertae_sedis;

/// <summary>
/// Abstract class for Felidae incertae sedis (no rank).
/// NCBI TaxId: 2927071
/// </summary>
public abstract class Felidae_incertae_sedis : Felidae, IFelidae_incertae_sedis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Felidae incertae sedis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2927071;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Felidae_incertae_sedis";
}

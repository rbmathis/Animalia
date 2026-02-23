using AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Anatidae_incertae_sedis;

/// <summary>
/// Abstract class for Anatidae incertae sedis (no rank).
/// NCBI TaxId: 2068731
/// </summary>
public abstract class Anatidae_incertae_sedis : Anatidae, IAnatidae_incertae_sedis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anatidae incertae sedis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2068731;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Anatidae_incertae_sedis";
}

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Threskiornithidae.Phimosus;

/// <summary>
/// Species: Phimosus infuscatus
/// NCBI TaxId: 555323
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phimosus_infuscatus : Phimosus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phimosus infuscatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phimosus_infuscatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 555323;
}

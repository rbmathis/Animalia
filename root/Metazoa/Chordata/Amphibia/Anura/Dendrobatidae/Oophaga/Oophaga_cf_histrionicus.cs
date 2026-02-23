namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dendrobatidae.Oophaga;

/// <summary>
/// Species: Oophaga cf. histrionicus
/// NCBI TaxId: 111066
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Oophaga_cf_histrionicus : Oophaga
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Oophaga cf. histrionicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Oophaga_cf_histrionicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 111066;
}

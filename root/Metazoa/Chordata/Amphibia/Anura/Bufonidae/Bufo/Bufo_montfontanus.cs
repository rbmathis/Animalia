namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Bufo;

/// <summary>
/// Species: Bufo montfontanus
/// NCBI TaxId: 2575949
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Bufo_montfontanus : Bufo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Bufo montfontanus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Bufo_montfontanus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2575949;
}

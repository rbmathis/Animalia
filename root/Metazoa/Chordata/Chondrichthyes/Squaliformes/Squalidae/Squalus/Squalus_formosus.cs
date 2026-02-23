namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Squalidae.Squalus;

/// <summary>
/// Species: Squalus formosus
/// NCBI TaxId: 1443580
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Squalus_formosus : Squalus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Squalus formosus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Squalus_formosus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1443580;
}

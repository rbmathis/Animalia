namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Hyla;

/// <summary>
/// Species: Hyla simplex
/// NCBI TaxId: 334658
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hyla_simplex : Hyla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hyla simplex";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hyla_simplex";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 334658;
}

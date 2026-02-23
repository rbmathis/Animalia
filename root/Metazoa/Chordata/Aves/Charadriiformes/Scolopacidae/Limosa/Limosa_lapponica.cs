namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Scolopacidae.Limosa;

/// <summary>
/// Species: Limosa lapponica
/// NCBI TaxId: 161683
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Limosa_lapponica : Limosa
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Limosa lapponica";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Limosa_lapponica";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 161683;
}

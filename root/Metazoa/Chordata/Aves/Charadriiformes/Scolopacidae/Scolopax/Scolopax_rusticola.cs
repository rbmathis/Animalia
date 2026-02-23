namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Scolopacidae.Scolopax;

/// <summary>
/// Species: Scolopax rusticola
/// NCBI TaxId: 100826
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Scolopax_rusticola : Scolopax
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Scolopax rusticola";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Scolopax_rusticola";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 100826;
}

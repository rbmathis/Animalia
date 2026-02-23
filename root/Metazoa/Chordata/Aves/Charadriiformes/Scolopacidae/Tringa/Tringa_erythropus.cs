namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Scolopacidae.Tringa;

/// <summary>
/// Species: Tringa erythropus
/// NCBI TaxId: 272050
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tringa_erythropus : Tringa
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tringa erythropus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tringa_erythropus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 272050;
}

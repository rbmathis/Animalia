namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Sayornis;

/// <summary>
/// Species: Sayornis nigricans
/// NCBI TaxId: 183530
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sayornis_nigricans : Sayornis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sayornis nigricans";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sayornis_nigricans";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 183530;
}

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Mauremys;

/// <summary>
/// Species: Mauremys japonica
/// NCBI TaxId: 176196
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mauremys_japonica : Mauremys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mauremys japonica";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mauremys_japonica";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 176196;
}

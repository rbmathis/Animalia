namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Cuculidae.Scythrops;

/// <summary>
/// Species: Scythrops novaehollandiae
/// NCBI TaxId: 30394
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Scythrops_novaehollandiae : Scythrops
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Scythrops novaehollandiae";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Scythrops_novaehollandiae";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 30394;
}

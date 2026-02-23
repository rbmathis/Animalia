namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae.Pudu;

/// <summary>
/// Species: Pudu puda
/// NCBI TaxId: 163861
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pudu_puda : Pudu
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pudu puda";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pudu_puda";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 163861;
}

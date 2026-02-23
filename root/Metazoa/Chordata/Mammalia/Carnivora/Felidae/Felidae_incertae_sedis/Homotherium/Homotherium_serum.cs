namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Felidae_incertae_sedis.Homotherium;

/// <summary>
/// Species: Homotherium serum
/// NCBI TaxId: 339614
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Homotherium_serum : Homotherium
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Homotherium serum";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Homotherium_serum";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 339614;
}

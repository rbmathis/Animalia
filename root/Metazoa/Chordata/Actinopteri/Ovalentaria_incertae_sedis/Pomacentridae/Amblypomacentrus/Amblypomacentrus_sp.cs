namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Amblypomacentrus;

/// <summary>
/// Species: Amblypomacentrus sp.
/// NCBI TaxId: 3446422
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Amblypomacentrus_sp : Amblypomacentrus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Amblypomacentrus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Amblypomacentrus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3446422;
}

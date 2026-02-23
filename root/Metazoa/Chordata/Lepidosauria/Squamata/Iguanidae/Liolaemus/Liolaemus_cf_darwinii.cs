namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae.Liolaemus;

/// <summary>
/// Species: Liolaemus cf. darwinii
/// NCBI TaxId: 350903
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Liolaemus_cf_darwinii : Liolaemus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Liolaemus cf. darwinii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Liolaemus_cf_darwinii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 350903;
}

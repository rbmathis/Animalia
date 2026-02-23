namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Leptodactylidae.Leptodactylus;

/// <summary>
/// Species: Leptodactylus cf. mystaceus FMM-2020
/// NCBI TaxId: 2713520
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Leptodactylus_cf_mystaceus_FMM_2020 : Leptodactylus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Leptodactylus cf. mystaceus FMM-2020";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Leptodactylus_cf_mystaceus_FMM_2020";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2713520;
}

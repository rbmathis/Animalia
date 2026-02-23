namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Malacanthidae.Branchiostegus;

/// <summary>
/// Species: Branchiostegus auratus
/// NCBI TaxId: 546018
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Branchiostegus_auratus : Branchiostegus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Branchiostegus auratus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Branchiostegus_auratus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 546018;
}

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Leptodactylidae.Leptodactylus;

/// <summary>
/// Species: Leptodactylus laticeps
/// NCBI TaxId: 1615745
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Leptodactylus_laticeps : Leptodactylus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Leptodactylus laticeps";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Leptodactylus_laticeps";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1615745;
}

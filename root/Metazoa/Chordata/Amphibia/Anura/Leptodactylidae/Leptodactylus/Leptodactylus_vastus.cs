namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Leptodactylidae.Leptodactylus;

/// <summary>
/// Species: Leptodactylus vastus
/// NCBI TaxId: 326589
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Leptodactylus_vastus : Leptodactylus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Leptodactylus vastus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Leptodactylus_vastus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 326589;
}

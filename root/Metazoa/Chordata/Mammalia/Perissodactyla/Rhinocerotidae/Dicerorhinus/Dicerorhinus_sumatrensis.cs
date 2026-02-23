namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Rhinocerotidae.Dicerorhinus;

/// <summary>
/// Species: Dicerorhinus sumatrensis
/// NCBI TaxId: 89632
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Dicerorhinus_sumatrensis : Dicerorhinus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Dicerorhinus sumatrensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Dicerorhinus_sumatrensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 89632;
}

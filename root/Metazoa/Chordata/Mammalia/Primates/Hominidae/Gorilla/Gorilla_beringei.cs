namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Hominidae.Gorilla;

/// <summary>
/// Species: Gorilla beringei
/// NCBI TaxId: 499232
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gorilla_beringei : Gorilla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gorilla beringei";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gorilla_beringei";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 499232;
}

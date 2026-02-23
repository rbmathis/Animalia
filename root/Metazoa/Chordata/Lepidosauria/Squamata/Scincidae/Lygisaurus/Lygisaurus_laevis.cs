namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Lygisaurus;

/// <summary>
/// Species: Lygisaurus laevis
/// NCBI TaxId: 583259
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lygisaurus_laevis : Lygisaurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lygisaurus laevis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lygisaurus_laevis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 583259;
}

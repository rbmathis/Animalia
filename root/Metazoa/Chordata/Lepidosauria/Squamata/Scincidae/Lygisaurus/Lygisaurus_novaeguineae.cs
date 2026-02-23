namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Lygisaurus;

/// <summary>
/// Species: Lygisaurus novaeguineae
/// NCBI TaxId: 124112
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lygisaurus_novaeguineae : Lygisaurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lygisaurus novaeguineae";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lygisaurus_novaeguineae";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 124112;
}

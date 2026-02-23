namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelobatidae.Pelobates;

/// <summary>
/// Species: Pelobates fuscus
/// NCBI TaxId: 191477
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pelobates_fuscus : Pelobates
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pelobates fuscus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pelobates_fuscus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 191477;
}

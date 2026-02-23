namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Anaxyrus;

/// <summary>
/// Species: Anaxyrus fowleri x Anaxyrus americanus
/// NCBI TaxId: 192202
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anaxyrus_fowleri_x_Anaxyrus_americanus : Anaxyrus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anaxyrus fowleri x Anaxyrus americanus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anaxyrus_fowleri_x_Anaxyrus_americanus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 192202;
}

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae.Palea;

/// <summary>
/// Species: Palea steindachneri
/// NCBI TaxId: 161718
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Palea_steindachneri : Palea
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Palea steindachneri";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Palea_steindachneri";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 161718;
}

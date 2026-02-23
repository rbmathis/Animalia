namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Caeciliidae.Caecilia;

/// <summary>
/// Species: Caecilia leucocephala
/// NCBI TaxId: 3231037
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Caecilia_leucocephala : Caecilia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Caecilia leucocephala";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Caecilia_leucocephala";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3231037;
}

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Kinosternidae.Kinosternon;

/// <summary>
/// Species: Kinosternon steindachneri
/// NCBI TaxId: 3146707
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Kinosternon_steindachneri : Kinosternon
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Kinosternon steindachneri";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Kinosternon_steindachneri";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3146707;
}

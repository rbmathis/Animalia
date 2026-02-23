namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Trachemys;

/// <summary>
/// Species: Trachemys adiutrix
/// NCBI TaxId: 365622
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Trachemys_adiutrix : Trachemys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Trachemys adiutrix";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Trachemys_adiutrix";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 365622;
}

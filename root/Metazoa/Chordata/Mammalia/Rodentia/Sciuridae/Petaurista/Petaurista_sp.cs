namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Petaurista;

/// <summary>
/// Species: Petaurista sp.
/// NCBI TaxId: 3476156
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Petaurista_sp : Petaurista
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Petaurista sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Petaurista_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3476156;
}

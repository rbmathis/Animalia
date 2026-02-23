namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Herpestidae.Herpestes;

/// <summary>
/// Species: Herpestes sp.
/// NCBI TaxId: 3088348
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Herpestes_sp : Herpestes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Herpestes sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Herpestes_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3088348;
}

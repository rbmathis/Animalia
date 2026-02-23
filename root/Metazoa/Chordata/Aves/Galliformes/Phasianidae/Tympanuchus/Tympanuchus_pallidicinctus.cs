namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Tympanuchus;

/// <summary>
/// Species: Tympanuchus pallidicinctus
/// NCBI TaxId: 109042
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tympanuchus_pallidicinctus : Tympanuchus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tympanuchus pallidicinctus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tympanuchus_pallidicinctus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 109042;
}

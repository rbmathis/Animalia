namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Sayornis;

/// <summary>
/// Species: Sayornis phoebe
/// NCBI TaxId: 56315
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sayornis_phoebe : Sayornis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sayornis phoebe";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sayornis_phoebe";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 56315;
}

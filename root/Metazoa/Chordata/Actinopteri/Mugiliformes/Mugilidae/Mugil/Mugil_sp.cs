namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae.Mugil;

/// <summary>
/// Species: Mugil sp.
/// NCBI TaxId: 3122172
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mugil_sp : Mugil
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mugil sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mugil_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3122172;
}

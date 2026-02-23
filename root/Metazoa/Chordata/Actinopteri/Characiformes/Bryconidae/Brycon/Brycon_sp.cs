namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Bryconidae.Brycon;

/// <summary>
/// Species: Brycon sp.
/// NCBI TaxId: 42586
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Brycon_sp : Brycon
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Brycon sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Brycon_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 42586;
}

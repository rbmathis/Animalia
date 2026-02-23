namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Columba;

/// <summary>
/// Species: Columba sp.
/// NCBI TaxId: 8933
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Columba_sp : Columba
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Columba sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Columba_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8933;
}

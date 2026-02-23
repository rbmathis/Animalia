namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Ptilonorhynchidae.Amblyornis;

/// <summary>
/// Species: Amblyornis inornata
/// NCBI TaxId: 2699200
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Amblyornis_inornata : Amblyornis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Amblyornis inornata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Amblyornis_inornata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2699200;
}

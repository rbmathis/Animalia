namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Turdus;

/// <summary>
/// Species: Turdus simillimus
/// NCBI TaxId: 486360
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Turdus_simillimus : Turdus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Turdus simillimus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Turdus_simillimus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 486360;
}

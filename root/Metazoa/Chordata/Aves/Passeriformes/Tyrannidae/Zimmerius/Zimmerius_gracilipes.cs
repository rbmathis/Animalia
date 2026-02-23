namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Zimmerius;

/// <summary>
/// Species: Zimmerius gracilipes
/// NCBI TaxId: 502661
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Zimmerius_gracilipes : Zimmerius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Zimmerius gracilipes";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Zimmerius_gracilipes";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 502661;
}

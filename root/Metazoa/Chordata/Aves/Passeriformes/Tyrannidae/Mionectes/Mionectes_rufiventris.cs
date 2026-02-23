namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Mionectes;

/// <summary>
/// Species: Mionectes rufiventris
/// NCBI TaxId: 360206
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mionectes_rufiventris : Mionectes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mionectes rufiventris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mionectes_rufiventris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 360206;
}

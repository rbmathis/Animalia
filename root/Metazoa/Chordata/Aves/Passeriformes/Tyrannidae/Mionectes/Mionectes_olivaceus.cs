namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Mionectes;

/// <summary>
/// Species: Mionectes olivaceus
/// NCBI TaxId: 430701
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mionectes_olivaceus : Mionectes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mionectes olivaceus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mionectes_olivaceus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 430701;
}

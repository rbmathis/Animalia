namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Leiothrichidae.Garrulax;

/// <summary>
/// Species: Garrulax leucolophus
/// NCBI TaxId: 98127
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Garrulax_leucolophus : Garrulax
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Garrulax leucolophus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Garrulax_leucolophus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 98127;
}

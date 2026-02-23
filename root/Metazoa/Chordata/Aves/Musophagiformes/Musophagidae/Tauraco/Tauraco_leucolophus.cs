namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Musophagiformes.Musophagidae.Tauraco;

/// <summary>
/// Species: Tauraco leucolophus
/// NCBI TaxId: 119415
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tauraco_leucolophus : Tauraco
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tauraco leucolophus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tauraco_leucolophus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 119415;
}

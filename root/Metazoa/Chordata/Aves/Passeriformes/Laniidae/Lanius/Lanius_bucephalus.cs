namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Laniidae.Lanius;

/// <summary>
/// Species: Lanius bucephalus
/// NCBI TaxId: 125284
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lanius_bucephalus : Lanius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lanius bucephalus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lanius_bucephalus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 125284;
}

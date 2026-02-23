namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Platysteira;

/// <summary>
/// Species: Platysteira cyanea
/// NCBI TaxId: 107226
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Platysteira_cyanea : Platysteira
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Platysteira cyanea";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Platysteira_cyanea";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 107226;
}

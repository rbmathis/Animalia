namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Turdus;

/// <summary>
/// Species: Turdus aurantius
/// NCBI TaxId: 411527
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Turdus_aurantius : Turdus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Turdus aurantius";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Turdus_aurantius";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 411527;
}

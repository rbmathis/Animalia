namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Certhiidae.Troglodytes;

/// <summary>
/// Species: Troglodytes rufociliatus
/// NCBI TaxId: 109450
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Troglodytes_rufociliatus : Troglodytes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Troglodytes rufociliatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Troglodytes_rufociliatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 109450;
}

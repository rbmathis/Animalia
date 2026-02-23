namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae.Acrocephalus;

/// <summary>
/// Species: Acrocephalus arundinaceus
/// NCBI TaxId: 39621
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Acrocephalus_arundinaceus : Acrocephalus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Acrocephalus arundinaceus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Acrocephalus_arundinaceus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 39621;
}

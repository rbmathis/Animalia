namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Otus;

/// <summary>
/// Species: Otus sp. JJF-2008
/// NCBI TaxId: 543875
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Otus_sp_JJF_2008 : Otus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Otus sp. JJF-2008";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Otus_sp_JJF_2008";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 543875;
}

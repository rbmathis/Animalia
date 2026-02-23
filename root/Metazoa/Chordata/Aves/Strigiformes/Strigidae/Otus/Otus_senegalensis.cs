namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Otus;

/// <summary>
/// Species: Otus senegalensis
/// NCBI TaxId: 543872
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Otus_senegalensis : Otus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Otus senegalensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Otus_senegalensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 543872;
}

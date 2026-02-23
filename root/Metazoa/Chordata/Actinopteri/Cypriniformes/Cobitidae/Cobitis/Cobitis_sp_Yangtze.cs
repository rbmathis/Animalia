namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cobitidae.Cobitis;

/// <summary>
/// Species: Cobitis sp. 'Yangtze'
/// NCBI TaxId: 1707111
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cobitis_sp_Yangtze : Cobitis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cobitis sp. 'Yangtze'";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cobitis_sp_Yangtze";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1707111;
}

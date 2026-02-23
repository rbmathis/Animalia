namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Proboscidea.Elephantidae.Elephas;

/// <summary>
/// Species: Elephas maximus
/// NCBI TaxId: 9783
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Elephas_maximus : Elephas
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Elephas maximus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Elephas_maximus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9783;
}

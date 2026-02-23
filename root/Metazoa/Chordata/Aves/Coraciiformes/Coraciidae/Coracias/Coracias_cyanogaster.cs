namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Coraciidae.Coracias;

/// <summary>
/// Species: Coracias cyanogaster
/// NCBI TaxId: 1547490
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Coracias_cyanogaster : Coracias
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Coracias cyanogaster";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Coracias_cyanogaster";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1547490;
}

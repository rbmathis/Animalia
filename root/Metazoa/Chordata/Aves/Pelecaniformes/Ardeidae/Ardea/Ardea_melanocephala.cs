namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Ardeidae.Ardea;

/// <summary>
/// Species: Ardea melanocephala
/// NCBI TaxId: 2492403
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ardea_melanocephala : Ardea
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ardea melanocephala";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ardea_melanocephala";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2492403;
}

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Balaenicipitidae.Balaeniceps;

/// <summary>
/// Species: Balaeniceps rex
/// NCBI TaxId: 33584
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Balaeniceps_rex : Balaeniceps
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Balaeniceps rex";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Balaeniceps_rex";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 33584;
}

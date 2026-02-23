namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Phlebobranchia.Cionidae.Ciona;

/// <summary>
/// Species: Ciona intestinalis
/// NCBI TaxId: 7719
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ciona_intestinalis : Ciona
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ciona intestinalis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ciona_intestinalis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 7719;
}

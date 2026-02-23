namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Aldabrachelys;

/// <summary>
/// Species: Aldabrachelys gigantea
/// NCBI TaxId: 167804
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Aldabrachelys_gigantea : Aldabrachelys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Aldabrachelys gigantea";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Aldabrachelys_gigantea";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 167804;
}

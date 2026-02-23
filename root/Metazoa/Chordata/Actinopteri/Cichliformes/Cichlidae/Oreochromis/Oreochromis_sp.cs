namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Oreochromis;

/// <summary>
/// Species: Oreochromis sp.
/// NCBI TaxId: 3139419
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Oreochromis_sp : Oreochromis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Oreochromis sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Oreochromis_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3139419;
}

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Pternistis;

/// <summary>
/// Species: Pternistis erckelii
/// NCBI TaxId: 9022
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pternistis_erckelii : Pternistis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pternistis erckelii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pternistis_erckelii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9022;
}

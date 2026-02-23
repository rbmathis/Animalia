namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Scinax;

/// <summary>
/// Species: Scinax melanodactylus
/// NCBI TaxId: 3045567
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Scinax_melanodactylus : Scinax
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Scinax melanodactylus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Scinax_melanodactylus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3045567;
}

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Odontobatrachidae.Odontobatrachus;

/// <summary>
/// Species: Odontobatrachus smithi
/// NCBI TaxId: 1649822
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Odontobatrachus_smithi : Odontobatrachus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Odontobatrachus smithi";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Odontobatrachus_smithi";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1649822;
}

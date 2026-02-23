using AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Chelonoidis;

/// <summary>
/// Abstract class for Chelonoidis (genus).
/// NCBI TaxId: 904181
/// </summary>
public abstract class Chelonoidis : Testudinidae, IChelonoidis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chelonoidis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 904181;

    /// <inheritdoc />
    public virtual string GenusName => "Chelonoidis";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}

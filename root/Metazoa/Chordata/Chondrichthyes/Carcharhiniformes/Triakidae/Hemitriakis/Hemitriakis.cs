using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Triakidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Triakidae.Hemitriakis;

/// <summary>
/// Abstract class for Hemitriakis (genus).
/// NCBI TaxId: 30491
/// </summary>
public abstract class Hemitriakis : Triakidae, IHemitriakis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemitriakis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 30491;

    /// <inheritdoc />
    public virtual string GenusName => "Hemitriakis";

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

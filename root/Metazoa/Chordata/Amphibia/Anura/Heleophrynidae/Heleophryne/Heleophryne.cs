using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Heleophrynidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Heleophrynidae.Heleophryne;

/// <summary>
/// Abstract class for Heleophryne (genus).
/// NCBI TaxId: 32643
/// </summary>
public abstract class Heleophryne : Heleophrynidae, IHeleophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Heleophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 32643;

    /// <inheritdoc />
    public virtual string GenusName => "Heleophryne";

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

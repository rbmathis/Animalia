using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dicroglossidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dicroglossidae.Minervarya;

/// <summary>
/// Abstract class for Minervarya (genus).
/// NCBI TaxId: 2545484
/// </summary>
public abstract class Minervarya : Dicroglossidae, IMinervarya
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Minervarya";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2545484;

    /// <inheritdoc />
    public virtual string GenusName => "Minervarya";

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

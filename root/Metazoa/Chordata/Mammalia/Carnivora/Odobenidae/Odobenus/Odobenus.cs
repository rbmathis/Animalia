using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Odobenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Odobenidae.Odobenus;

/// <summary>
/// Abstract class for Odobenus (genus).
/// NCBI TaxId: 9706
/// </summary>
public abstract class Odobenus : Odobenidae, IOdobenus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Odobenus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9706;

    /// <inheritdoc />
    public virtual string GenusName => "Odobenus";

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

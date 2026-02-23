using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Monodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Monodontidae.Delphinapterus;

/// <summary>
/// Abstract class for Delphinapterus (genus).
/// NCBI TaxId: 9748
/// </summary>
public abstract class Delphinapterus : Monodontidae, IDelphinapterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Delphinapterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9748;

    /// <inheritdoc />
    public virtual string GenusName => "Delphinapterus";

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

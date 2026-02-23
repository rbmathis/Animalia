using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Haemulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Haemulidae.Paranisotremus;

/// <summary>
/// Abstract class for Paranisotremus (genus).
/// NCBI TaxId: 3363453
/// </summary>
public abstract class Paranisotremus : Haemulidae, IParanisotremus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paranisotremus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3363453;

    /// <inheritdoc />
    public virtual string GenusName => "Paranisotremus";

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

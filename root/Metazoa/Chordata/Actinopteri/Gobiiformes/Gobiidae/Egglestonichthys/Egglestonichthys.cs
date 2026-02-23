using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Egglestonichthys;

/// <summary>
/// Abstract class for Egglestonichthys (genus).
/// NCBI TaxId: 3078567
/// </summary>
public abstract class Egglestonichthys : Gobiidae, IEgglestonichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Egglestonichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3078567;

    /// <inheritdoc />
    public virtual string GenusName => "Egglestonichthys";

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

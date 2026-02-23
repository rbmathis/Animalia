using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Alepocephalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Alepocephalidae.Xenodermichthys;

/// <summary>
/// Abstract class for Xenodermichthys (genus).
/// NCBI TaxId: 492050
/// </summary>
public abstract class Xenodermichthys : Alepocephalidae, IXenodermichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xenodermichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 492050;

    /// <inheritdoc />
    public virtual string GenusName => "Xenodermichthys";

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

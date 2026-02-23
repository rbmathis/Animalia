using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Platytroctidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Platytroctidae.Sagamichthys;

/// <summary>
/// Abstract class for Sagamichthys (genus).
/// NCBI TaxId: 319781
/// </summary>
public abstract class Sagamichthys : Platytroctidae, ISagamichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sagamichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 319781;

    /// <inheritdoc />
    public virtual string GenusName => "Sagamichthys";

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

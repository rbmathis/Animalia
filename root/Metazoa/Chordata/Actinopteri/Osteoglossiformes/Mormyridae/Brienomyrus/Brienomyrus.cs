using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae.Brienomyrus;

/// <summary>
/// Abstract class for Brienomyrus (genus).
/// NCBI TaxId: 42634
/// </summary>
public abstract class Brienomyrus : Mormyridae, IBrienomyrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Brienomyrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42634;

    /// <inheritdoc />
    public virtual string GenusName => "Brienomyrus";

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

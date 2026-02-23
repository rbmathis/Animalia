using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Platytroctidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Platytroctidae.Normichthys;

/// <summary>
/// Abstract class for Normichthys (genus).
/// NCBI TaxId: 443645
/// </summary>
public abstract class Normichthys : Platytroctidae, INormichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Normichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 443645;

    /// <inheritdoc />
    public virtual string GenusName => "Normichthys";

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

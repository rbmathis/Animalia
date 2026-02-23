using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Ursidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Ursidae.Ailuropoda;

/// <summary>
/// Abstract class for Ailuropoda (genus).
/// NCBI TaxId: 9645
/// </summary>
public abstract class Ailuropoda : Ursidae, IAiluropoda
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ailuropoda";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9645;

    /// <inheritdoc />
    public virtual string GenusName => "Ailuropoda";

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

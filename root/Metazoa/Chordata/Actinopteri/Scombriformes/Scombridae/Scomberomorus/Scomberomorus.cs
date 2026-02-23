using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Scombridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Scombridae.Scomberomorus;

/// <summary>
/// Abstract class for Scomberomorus (genus).
/// NCBI TaxId: 13678
/// </summary>
public abstract class Scomberomorus : Scombridae, IScomberomorus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scomberomorus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 13678;

    /// <inheritdoc />
    public virtual string GenusName => "Scomberomorus";

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

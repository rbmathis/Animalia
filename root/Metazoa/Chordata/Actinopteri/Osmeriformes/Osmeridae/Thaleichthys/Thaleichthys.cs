using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osmeriformes.Osmeridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osmeriformes.Osmeridae.Thaleichthys;

/// <summary>
/// Abstract class for Thaleichthys (genus).
/// NCBI TaxId: 182233
/// </summary>
public abstract class Thaleichthys : Osmeridae, IThaleichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thaleichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 182233;

    /// <inheritdoc />
    public virtual string GenusName => "Thaleichthys";

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

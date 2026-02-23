using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae.Gnathonemus;

/// <summary>
/// Abstract class for Gnathonemus (genus).
/// NCBI TaxId: 42644
/// </summary>
public abstract class Gnathonemus : Mormyridae, IGnathonemus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gnathonemus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42644;

    /// <inheritdoc />
    public virtual string GenusName => "Gnathonemus";

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

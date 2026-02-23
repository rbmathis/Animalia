using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae.Paramormyrops;

/// <summary>
/// Abstract class for Paramormyrops (genus).
/// NCBI TaxId: 91732
/// </summary>
public abstract class Paramormyrops : Mormyridae, IParamormyrops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paramormyrops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 91732;

    /// <inheritdoc />
    public virtual string GenusName => "Paramormyrops";

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

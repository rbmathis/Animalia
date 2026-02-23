using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae.Mormyrops;

/// <summary>
/// Abstract class for Mormyrops (genus).
/// NCBI TaxId: 91728
/// </summary>
public abstract class Mormyrops : Mormyridae, IMormyrops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mormyrops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 91728;

    /// <inheritdoc />
    public virtual string GenusName => "Mormyrops";

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

using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae.Malacocephalus;

/// <summary>
/// Abstract class for Malacocephalus (genus).
/// NCBI TaxId: 630737
/// </summary>
public abstract class Malacocephalus : Macrouridae, IMalacocephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Malacocephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 630737;

    /// <inheritdoc />
    public virtual string GenusName => "Malacocephalus";

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

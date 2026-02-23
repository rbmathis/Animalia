using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae.Mesovagus;

/// <summary>
/// Abstract class for Mesovagus (genus).
/// NCBI TaxId: 3363440
/// </summary>
public abstract class Mesovagus : Macrouridae, IMesovagus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mesovagus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3363440;

    /// <inheritdoc />
    public virtual string GenusName => "Mesovagus";

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

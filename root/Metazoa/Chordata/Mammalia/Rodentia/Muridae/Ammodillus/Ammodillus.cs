using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Ammodillus;

/// <summary>
/// Abstract class for Ammodillus (genus).
/// NCBI TaxId: 2993826
/// </summary>
public abstract class Ammodillus : Muridae, IAmmodillus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ammodillus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2993826;

    /// <inheritdoc />
    public virtual string GenusName => "Ammodillus";

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

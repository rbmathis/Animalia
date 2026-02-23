using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Dipodillus;

/// <summary>
/// Abstract class for Dipodillus (genus).
/// NCBI TaxId: 723803
/// </summary>
public abstract class Dipodillus : Muridae, IDipodillus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dipodillus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 723803;

    /// <inheritdoc />
    public virtual string GenusName => "Dipodillus";

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

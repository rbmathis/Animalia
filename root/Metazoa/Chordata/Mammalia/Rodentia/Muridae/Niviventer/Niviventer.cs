using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Niviventer;

/// <summary>
/// Abstract class for Niviventer (genus).
/// NCBI TaxId: 69082
/// </summary>
public abstract class Niviventer : Muridae, INiviventer
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Niviventer";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 69082;

    /// <inheritdoc />
    public virtual string GenusName => "Niviventer";

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

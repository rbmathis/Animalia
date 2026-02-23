using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Gerbillurus;

/// <summary>
/// Abstract class for Gerbillurus (genus).
/// NCBI TaxId: 49439
/// </summary>
public abstract class Gerbillurus : Muridae, IGerbillurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gerbillurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 49439;

    /// <inheritdoc />
    public virtual string GenusName => "Gerbillurus";

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

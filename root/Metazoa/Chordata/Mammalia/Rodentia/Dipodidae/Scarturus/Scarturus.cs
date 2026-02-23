using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dipodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dipodidae.Scarturus;

/// <summary>
/// Abstract class for Scarturus (genus).
/// NCBI TaxId: 2494513
/// </summary>
public abstract class Scarturus : Dipodidae, IScarturus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scarturus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2494513;

    /// <inheritdoc />
    public virtual string GenusName => "Scarturus";

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

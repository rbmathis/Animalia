using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Reithrodon;

/// <summary>
/// Abstract class for Reithrodon (genus).
/// NCBI TaxId: 56233
/// </summary>
public abstract class Reithrodon : Cricetidae, IReithrodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Reithrodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 56233;

    /// <inheritdoc />
    public virtual string GenusName => "Reithrodon";

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

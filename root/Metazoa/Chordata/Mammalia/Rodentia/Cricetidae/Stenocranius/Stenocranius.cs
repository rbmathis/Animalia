using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Stenocranius;

/// <summary>
/// Abstract class for Stenocranius (genus).
/// NCBI TaxId: 3371040
/// </summary>
public abstract class Stenocranius : Cricetidae, IStenocranius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stenocranius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3371040;

    /// <inheritdoc />
    public virtual string GenusName => "Stenocranius";

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

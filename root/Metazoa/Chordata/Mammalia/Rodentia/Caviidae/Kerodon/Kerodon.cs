using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Caviidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Caviidae.Kerodon;

/// <summary>
/// Abstract class for Kerodon (genus).
/// NCBI TaxId: 181538
/// </summary>
public abstract class Kerodon : Caviidae, IKerodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kerodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 181538;

    /// <inheritdoc />
    public virtual string GenusName => "Kerodon";

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

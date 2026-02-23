using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Dermoptera.Cynocephalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Dermoptera.Cynocephalidae.Galeopterus;

/// <summary>
/// Abstract class for Galeopterus (genus).
/// NCBI TaxId: 482536
/// </summary>
public abstract class Galeopterus : Cynocephalidae, IGaleopterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Galeopterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 482536;

    /// <inheritdoc />
    public virtual string GenusName => "Galeopterus";

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

using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Psettodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Psettodidae.Psettodes;

/// <summary>
/// Abstract class for Psettodes (genus).
/// NCBI TaxId: 94240
/// </summary>
public abstract class Psettodes : Psettodidae, IPsettodes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Psettodes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 94240;

    /// <inheritdoc />
    public virtual string GenusName => "Psettodes";

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

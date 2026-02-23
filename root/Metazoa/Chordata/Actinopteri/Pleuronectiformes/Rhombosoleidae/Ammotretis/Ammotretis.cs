using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Rhombosoleidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Rhombosoleidae.Ammotretis;

/// <summary>
/// Abstract class for Ammotretis (genus).
/// NCBI TaxId: 443749
/// </summary>
public abstract class Ammotretis : Rhombosoleidae, IAmmotretis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ammotretis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 443749;

    /// <inheritdoc />
    public virtual string GenusName => "Ammotretis";

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

using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Soleidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Soleidae.Synclidopus;

/// <summary>
/// Abstract class for Synclidopus (genus).
/// NCBI TaxId: 2578409
/// </summary>
public abstract class Synclidopus : Soleidae, ISynclidopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Synclidopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2578409;

    /// <inheritdoc />
    public virtual string GenusName => "Synclidopus";

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

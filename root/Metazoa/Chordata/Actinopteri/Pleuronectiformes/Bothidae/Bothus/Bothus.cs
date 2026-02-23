using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Bothidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Bothidae.Bothus;

/// <summary>
/// Abstract class for Bothus (genus).
/// NCBI TaxId: 94920
/// </summary>
public abstract class Bothus : Bothidae, IBothus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bothus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 94920;

    /// <inheritdoc />
    public virtual string GenusName => "Bothus";

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

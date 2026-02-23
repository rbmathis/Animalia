using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Cyclopsettidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Cyclopsettidae.Etropus;

/// <summary>
/// Abstract class for Etropus (genus).
/// NCBI TaxId: 195610
/// </summary>
public abstract class Etropus : Cyclopsettidae, IEtropus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Etropus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 195610;

    /// <inheritdoc />
    public virtual string GenusName => "Etropus";

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

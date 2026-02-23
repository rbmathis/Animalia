using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Soleidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Soleidae.Dexillus;

/// <summary>
/// Abstract class for Dexillus (genus).
/// NCBI TaxId: 2202282
/// </summary>
public abstract class Dexillus : Soleidae, IDexillus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dexillus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2202282;

    /// <inheritdoc />
    public virtual string GenusName => "Dexillus";

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

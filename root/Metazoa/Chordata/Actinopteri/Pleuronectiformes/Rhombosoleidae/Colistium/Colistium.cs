using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Rhombosoleidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Rhombosoleidae.Colistium;

/// <summary>
/// Abstract class for Colistium (genus).
/// NCBI TaxId: 1156757
/// </summary>
public abstract class Colistium : Rhombosoleidae, IColistium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Colistium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1156757;

    /// <inheritdoc />
    public virtual string GenusName => "Colistium";

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

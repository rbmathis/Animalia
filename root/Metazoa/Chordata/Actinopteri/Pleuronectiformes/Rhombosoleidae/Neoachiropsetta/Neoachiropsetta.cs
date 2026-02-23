using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Rhombosoleidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Rhombosoleidae.Neoachiropsetta;

/// <summary>
/// Abstract class for Neoachiropsetta (genus).
/// NCBI TaxId: 443796
/// </summary>
public abstract class Neoachiropsetta : Rhombosoleidae, INeoachiropsetta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neoachiropsetta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 443796;

    /// <inheritdoc />
    public virtual string GenusName => "Neoachiropsetta";

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

using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Rhombosoleidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Rhombosoleidae.Mancopsetta;

/// <summary>
/// Abstract class for Mancopsetta (genus).
/// NCBI TaxId: 443795
/// </summary>
public abstract class Mancopsetta : Rhombosoleidae, IMancopsetta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mancopsetta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 443795;

    /// <inheritdoc />
    public virtual string GenusName => "Mancopsetta";

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

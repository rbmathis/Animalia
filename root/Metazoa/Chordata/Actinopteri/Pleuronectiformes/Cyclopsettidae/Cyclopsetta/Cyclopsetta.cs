using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Cyclopsettidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Cyclopsettidae.Cyclopsetta;

/// <summary>
/// Abstract class for Cyclopsetta (genus).
/// NCBI TaxId: 329464
/// </summary>
public abstract class Cyclopsetta : Cyclopsettidae, ICyclopsetta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cyclopsetta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 329464;

    /// <inheritdoc />
    public virtual string GenusName => "Cyclopsetta";

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

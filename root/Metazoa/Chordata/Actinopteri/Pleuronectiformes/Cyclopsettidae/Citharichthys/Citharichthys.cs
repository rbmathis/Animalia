using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Cyclopsettidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Cyclopsettidae.Citharichthys;

/// <summary>
/// Abstract class for Citharichthys (genus).
/// NCBI TaxId: 195599
/// </summary>
public abstract class Citharichthys : Cyclopsettidae, ICitharichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Citharichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 195599;

    /// <inheritdoc />
    public virtual string GenusName => "Citharichthys";

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

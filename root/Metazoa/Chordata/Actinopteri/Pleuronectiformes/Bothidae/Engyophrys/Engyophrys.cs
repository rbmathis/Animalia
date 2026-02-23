using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Bothidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Bothidae.Engyophrys;

/// <summary>
/// Abstract class for Engyophrys (genus).
/// NCBI TaxId: 1828469
/// </summary>
public abstract class Engyophrys : Bothidae, IEngyophrys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Engyophrys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1828469;

    /// <inheritdoc />
    public virtual string GenusName => "Engyophrys";

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

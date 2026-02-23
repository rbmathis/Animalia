using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Bothidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Bothidae.Engyprosopon;

/// <summary>
/// Abstract class for Engyprosopon (genus).
/// NCBI TaxId: 195606
/// </summary>
public abstract class Engyprosopon : Bothidae, IEngyprosopon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Engyprosopon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 195606;

    /// <inheritdoc />
    public virtual string GenusName => "Engyprosopon";

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

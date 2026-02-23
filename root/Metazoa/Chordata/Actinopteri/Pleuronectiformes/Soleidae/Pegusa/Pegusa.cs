using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Soleidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Soleidae.Pegusa;

/// <summary>
/// Abstract class for Pegusa (genus).
/// NCBI TaxId: 432165
/// </summary>
public abstract class Pegusa : Soleidae, IPegusa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pegusa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 432165;

    /// <inheritdoc />
    public virtual string GenusName => "Pegusa";

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

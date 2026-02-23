using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Soleidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Soleidae.Heteromycteris;

/// <summary>
/// Abstract class for Heteromycteris (genus).
/// NCBI TaxId: 195613
/// </summary>
public abstract class Heteromycteris : Soleidae, IHeteromycteris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Heteromycteris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 195613;

    /// <inheritdoc />
    public virtual string GenusName => "Heteromycteris";

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

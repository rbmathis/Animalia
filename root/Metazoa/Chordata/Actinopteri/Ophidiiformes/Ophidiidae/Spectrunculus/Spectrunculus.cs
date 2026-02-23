using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Spectrunculus;

/// <summary>
/// Abstract class for Spectrunculus (genus).
/// NCBI TaxId: 557425
/// </summary>
public abstract class Spectrunculus : Ophidiidae, ISpectrunculus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Spectrunculus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 557425;

    /// <inheritdoc />
    public virtual string GenusName => "Spectrunculus";

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

using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pilosa.Mylodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pilosa.Mylodontidae.Paramylodon;

/// <summary>
/// Abstract class for Paramylodon (genus).
/// NCBI TaxId: 2546651
/// </summary>
public abstract class Paramylodon : Mylodontidae, IParamylodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paramylodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2546651;

    /// <inheritdoc />
    public virtual string GenusName => "Paramylodon";

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

using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae.Kakamega;

/// <summary>
/// Abstract class for Kakamega (genus).
/// NCBI TaxId: 201333
/// </summary>
public abstract class Kakamega : Timaliidae, IKakamega
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kakamega";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 201333;

    /// <inheritdoc />
    public virtual string GenusName => "Kakamega";

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

using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Tarsiger;

/// <summary>
/// Abstract class for Tarsiger (genus).
/// NCBI TaxId: 2823303
/// </summary>
public abstract class Tarsiger : Turdidae, ITarsiger
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tarsiger";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2823303;

    /// <inheritdoc />
    public virtual string GenusName => "Tarsiger";

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

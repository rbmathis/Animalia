using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae.Stachyris;

/// <summary>
/// Abstract class for Stachyris (genus).
/// NCBI TaxId: 98149
/// </summary>
public abstract class Stachyris : Timaliidae, IStachyris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stachyris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 98149;

    /// <inheritdoc />
    public virtual string GenusName => "Stachyris";

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

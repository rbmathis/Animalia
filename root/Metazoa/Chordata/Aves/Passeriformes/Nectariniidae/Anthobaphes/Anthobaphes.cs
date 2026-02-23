using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Nectariniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Nectariniidae.Anthobaphes;

/// <summary>
/// Abstract class for Anthobaphes (genus).
/// NCBI TaxId: 1492856
/// </summary>
public abstract class Anthobaphes : Nectariniidae, IAnthobaphes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anthobaphes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1492856;

    /// <inheritdoc />
    public virtual string GenusName => "Anthobaphes";

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

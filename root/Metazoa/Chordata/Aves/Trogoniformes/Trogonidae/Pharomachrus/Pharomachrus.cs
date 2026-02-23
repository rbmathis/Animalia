using AnimalKingdom.root.Metazoa.Chordata.Aves.Trogoniformes.Trogonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Trogoniformes.Trogonidae.Pharomachrus;

/// <summary>
/// Abstract class for Pharomachrus (genus).
/// NCBI TaxId: 57429
/// </summary>
public abstract class Pharomachrus : Trogonidae, IPharomachrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pharomachrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57429;

    /// <inheritdoc />
    public virtual string GenusName => "Pharomachrus";

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

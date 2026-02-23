using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Galbulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Galbulidae.Brachygalba;

/// <summary>
/// Abstract class for Brachygalba (genus).
/// NCBI TaxId: 1118514
/// </summary>
public abstract class Brachygalba : Galbulidae, IBrachygalba
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Brachygalba";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1118514;

    /// <inheritdoc />
    public virtual string GenusName => "Brachygalba";

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

using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Ploceidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Ploceidae.Brachycope;

/// <summary>
/// Abstract class for Brachycope (genus).
/// NCBI TaxId: 1002749
/// </summary>
public abstract class Brachycope : Ploceidae, IBrachycope
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Brachycope";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1002749;

    /// <inheritdoc />
    public virtual string GenusName => "Brachycope";

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

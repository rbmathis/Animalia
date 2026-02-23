using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Artamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Artamidae.Melloria;

/// <summary>
/// Abstract class for Melloria (genus).
/// NCBI TaxId: 2547539
/// </summary>
public abstract class Melloria : Artamidae, IMelloria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Melloria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2547539;

    /// <inheritdoc />
    public virtual string GenusName => "Melloria";

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

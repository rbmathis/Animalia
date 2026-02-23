using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Artamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Artamidae.Strepera;

/// <summary>
/// Abstract class for Strepera (genus).
/// NCBI TaxId: 254662
/// </summary>
public abstract class Strepera : Artamidae, IStrepera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Strepera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 254662;

    /// <inheritdoc />
    public virtual string GenusName => "Strepera";

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

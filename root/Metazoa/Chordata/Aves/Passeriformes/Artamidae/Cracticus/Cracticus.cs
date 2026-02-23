using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Artamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Artamidae.Cracticus;

/// <summary>
/// Abstract class for Cracticus (genus).
/// NCBI TaxId: 254524
/// </summary>
public abstract class Cracticus : Artamidae, ICracticus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cracticus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 254524;

    /// <inheritdoc />
    public virtual string GenusName => "Cracticus";

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

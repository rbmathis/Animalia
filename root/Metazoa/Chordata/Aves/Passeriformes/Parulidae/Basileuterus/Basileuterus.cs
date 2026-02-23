using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae.Basileuterus;

/// <summary>
/// Abstract class for Basileuterus (genus).
/// NCBI TaxId: 85518
/// </summary>
public abstract class Basileuterus : Parulidae, IBasileuterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Basileuterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 85518;

    /// <inheritdoc />
    public virtual string GenusName => "Basileuterus";

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

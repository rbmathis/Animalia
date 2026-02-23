using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Poecilostreptus;

/// <summary>
/// Abstract class for Poecilostreptus (genus).
/// NCBI TaxId: 3150846
/// </summary>
public abstract class Poecilostreptus : Thraupidae, IPoecilostreptus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Poecilostreptus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3150846;

    /// <inheritdoc />
    public virtual string GenusName => "Poecilostreptus";

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

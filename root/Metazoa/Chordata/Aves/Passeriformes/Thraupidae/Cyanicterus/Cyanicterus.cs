using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Cyanicterus;

/// <summary>
/// Abstract class for Cyanicterus (genus).
/// NCBI TaxId: 1226231
/// </summary>
public abstract class Cyanicterus : Thraupidae, ICyanicterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cyanicterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1226231;

    /// <inheritdoc />
    public virtual string GenusName => "Cyanicterus";

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

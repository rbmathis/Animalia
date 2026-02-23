using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Zebrus;

/// <summary>
/// Abstract class for Zebrus (genus).
/// NCBI TaxId: 85425
/// </summary>
public abstract class Zebrus : Gobiidae, IZebrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Zebrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 85425;

    /// <inheritdoc />
    public virtual string GenusName => "Zebrus";

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

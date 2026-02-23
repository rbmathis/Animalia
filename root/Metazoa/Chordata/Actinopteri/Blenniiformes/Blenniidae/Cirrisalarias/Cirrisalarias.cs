using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Cirrisalarias;

/// <summary>
/// Abstract class for Cirrisalarias (genus).
/// NCBI TaxId: 1405692
/// </summary>
public abstract class Cirrisalarias : Blenniidae, ICirrisalarias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cirrisalarias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1405692;

    /// <inheritdoc />
    public virtual string GenusName => "Cirrisalarias";

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

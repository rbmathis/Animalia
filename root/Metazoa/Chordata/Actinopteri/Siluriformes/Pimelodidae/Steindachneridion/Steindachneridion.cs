using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae.Steindachneridion;

/// <summary>
/// Abstract class for Steindachneridion (genus).
/// NCBI TaxId: 380997
/// </summary>
public abstract class Steindachneridion : Pimelodidae, ISteindachneridion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Steindachneridion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 380997;

    /// <inheritdoc />
    public virtual string GenusName => "Steindachneridion";

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

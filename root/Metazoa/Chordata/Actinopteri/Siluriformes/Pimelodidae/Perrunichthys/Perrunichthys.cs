using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae.Perrunichthys;

/// <summary>
/// Abstract class for Perrunichthys (genus).
/// NCBI TaxId: 337674
/// </summary>
public abstract class Perrunichthys : Pimelodidae, IPerrunichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Perrunichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 337674;

    /// <inheritdoc />
    public virtual string GenusName => "Perrunichthys";

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

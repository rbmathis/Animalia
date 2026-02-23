using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae.Aguarunichthys;

/// <summary>
/// Abstract class for Aguarunichthys (genus).
/// NCBI TaxId: 1045362
/// </summary>
public abstract class Aguarunichthys : Pimelodidae, IAguarunichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aguarunichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1045362;

    /// <inheritdoc />
    public virtual string GenusName => "Aguarunichthys";

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

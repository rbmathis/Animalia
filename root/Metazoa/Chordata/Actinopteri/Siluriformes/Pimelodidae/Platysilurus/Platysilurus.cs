using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae.Platysilurus;

/// <summary>
/// Abstract class for Platysilurus (genus).
/// NCBI TaxId: 337782
/// </summary>
public abstract class Platysilurus : Pimelodidae, IPlatysilurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Platysilurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 337782;

    /// <inheritdoc />
    public virtual string GenusName => "Platysilurus";

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

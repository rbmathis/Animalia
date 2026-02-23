using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Diplomystidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Diplomystidae.Olivaichthys;

/// <summary>
/// Abstract class for Olivaichthys (genus).
/// NCBI TaxId: 1344483
/// </summary>
public abstract class Olivaichthys : Diplomystidae, IOlivaichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Olivaichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1344483;

    /// <inheritdoc />
    public virtual string GenusName => "Olivaichthys";

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

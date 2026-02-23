using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Heroina;

/// <summary>
/// Abstract class for Heroina (genus).
/// NCBI TaxId: 329338
/// </summary>
public abstract class Heroina : Cichlidae, IHeroina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Heroina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 329338;

    /// <inheritdoc />
    public virtual string GenusName => "Heroina";

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

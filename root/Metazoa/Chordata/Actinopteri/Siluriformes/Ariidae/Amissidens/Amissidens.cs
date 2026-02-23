using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae.Amissidens;

/// <summary>
/// Abstract class for Amissidens (genus).
/// NCBI TaxId: 591306
/// </summary>
public abstract class Amissidens : Ariidae, IAmissidens
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Amissidens";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 591306;

    /// <inheritdoc />
    public virtual string GenusName => "Amissidens";

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

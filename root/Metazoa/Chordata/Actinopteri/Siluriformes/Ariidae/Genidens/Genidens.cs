using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae.Genidens;

/// <summary>
/// Abstract class for Genidens (genus).
/// NCBI TaxId: 591324
/// </summary>
public abstract class Genidens : Ariidae, IGenidens
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Genidens";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 591324;

    /// <inheritdoc />
    public virtual string GenusName => "Genidens";

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

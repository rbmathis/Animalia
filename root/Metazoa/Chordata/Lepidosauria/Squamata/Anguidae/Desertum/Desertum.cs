using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Anguidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Anguidae.Desertum;

/// <summary>
/// Abstract class for Desertum (genus).
/// NCBI TaxId: 3342675
/// </summary>
public abstract class Desertum : Anguidae, IDesertum
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Desertum";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3342675;

    /// <inheritdoc />
    public virtual string GenusName => "Desertum";

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

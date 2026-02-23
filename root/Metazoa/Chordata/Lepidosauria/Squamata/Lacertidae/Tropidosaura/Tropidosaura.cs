using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Tropidosaura;

/// <summary>
/// Abstract class for Tropidosaura (genus).
/// NCBI TaxId: 81580
/// </summary>
public abstract class Tropidosaura : Lacertidae, ITropidosaura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tropidosaura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 81580;

    /// <inheritdoc />
    public virtual string GenusName => "Tropidosaura";

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

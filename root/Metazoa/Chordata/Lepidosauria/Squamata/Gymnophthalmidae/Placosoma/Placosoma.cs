using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Placosoma;

/// <summary>
/// Abstract class for Placosoma (genus).
/// NCBI TaxId: 174758
/// </summary>
public abstract class Placosoma : Gymnophthalmidae, IPlacosoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Placosoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 174758;

    /// <inheritdoc />
    public virtual string GenusName => "Placosoma";

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

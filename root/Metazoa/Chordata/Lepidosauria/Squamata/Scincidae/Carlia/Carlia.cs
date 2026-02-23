using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Carlia;

/// <summary>
/// Abstract class for Carlia (genus).
/// NCBI TaxId: 96728
/// </summary>
public abstract class Carlia : Scincidae, ICarlia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Carlia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 96728;

    /// <inheritdoc />
    public virtual string GenusName => "Carlia";

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

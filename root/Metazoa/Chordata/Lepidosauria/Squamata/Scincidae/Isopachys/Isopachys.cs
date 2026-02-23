using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Isopachys;

/// <summary>
/// Abstract class for Isopachys (genus).
/// NCBI TaxId: 96762
/// </summary>
public abstract class Isopachys : Scincidae, IIsopachys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Isopachys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 96762;

    /// <inheritdoc />
    public virtual string GenusName => "Isopachys";

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

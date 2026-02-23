using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Feylinia;

/// <summary>
/// Abstract class for Feylinia (genus).
/// NCBI TaxId: 230621
/// </summary>
public abstract class Feylinia : Scincidae, IFeylinia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Feylinia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 230621;

    /// <inheritdoc />
    public virtual string GenusName => "Feylinia";

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

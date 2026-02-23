using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Lipinia;

/// <summary>
/// Abstract class for Lipinia (genus).
/// NCBI TaxId: 71016
/// </summary>
public abstract class Lipinia : Scincidae, ILipinia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lipinia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 71016;

    /// <inheritdoc />
    public virtual string GenusName => "Lipinia";

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

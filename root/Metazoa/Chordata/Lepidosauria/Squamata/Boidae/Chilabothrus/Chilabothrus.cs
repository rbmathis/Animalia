using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Boidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Boidae.Chilabothrus;

/// <summary>
/// Abstract class for Chilabothrus (genus).
/// NCBI TaxId: 1336606
/// </summary>
public abstract class Chilabothrus : Boidae, IChilabothrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chilabothrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1336606;

    /// <inheritdoc />
    public virtual string GenusName => "Chilabothrus";

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

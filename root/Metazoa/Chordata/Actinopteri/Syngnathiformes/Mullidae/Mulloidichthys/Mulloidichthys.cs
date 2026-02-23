using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Mullidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Mullidae.Mulloidichthys;

/// <summary>
/// Abstract class for Mulloidichthys (genus).
/// NCBI TaxId: 342442
/// </summary>
public abstract class Mulloidichthys : Mullidae, IMulloidichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mulloidichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 342442;

    /// <inheritdoc />
    public virtual string GenusName => "Mulloidichthys";

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

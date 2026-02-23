using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Macropsobrycon;

/// <summary>
/// Abstract class for Macropsobrycon (genus).
/// NCBI TaxId: 681922
/// </summary>
public abstract class Macropsobrycon : Characidae, IMacropsobrycon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Macropsobrycon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 681922;

    /// <inheritdoc />
    public virtual string GenusName => "Macropsobrycon";

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

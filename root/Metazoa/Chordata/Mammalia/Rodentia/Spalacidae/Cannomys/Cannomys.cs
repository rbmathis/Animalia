using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Spalacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Spalacidae.Cannomys;

/// <summary>
/// Abstract class for Cannomys (genus).
/// NCBI TaxId: 1392511
/// </summary>
public abstract class Cannomys : Spalacidae, ICannomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cannomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1392511;

    /// <inheritdoc />
    public virtual string GenusName => "Cannomys";

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

using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cotingidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cotingidae.Ampelioides;

/// <summary>
/// Abstract class for Ampelioides (genus).
/// NCBI TaxId: 114270
/// </summary>
public abstract class Ampelioides : Cotingidae, IAmpelioides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ampelioides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 114270;

    /// <inheritdoc />
    public virtual string GenusName => "Ampelioides";

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

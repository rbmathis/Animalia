using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Mimidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Mimidae.Melanoptila;

/// <summary>
/// Abstract class for Melanoptila (genus).
/// NCBI TaxId: 111989
/// </summary>
public abstract class Melanoptila : Mimidae, IMelanoptila
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Melanoptila";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 111989;

    /// <inheritdoc />
    public virtual string GenusName => "Melanoptila";

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

using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae.Aimophila;

/// <summary>
/// Abstract class for Aimophila (genus).
/// NCBI TaxId: 194933
/// </summary>
public abstract class Aimophila : Passerellidae, IAimophila
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aimophila";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 194933;

    /// <inheritdoc />
    public virtual string GenusName => "Aimophila";

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

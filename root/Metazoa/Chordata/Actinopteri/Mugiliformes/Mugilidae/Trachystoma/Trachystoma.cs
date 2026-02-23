using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae.Trachystoma;

/// <summary>
/// Abstract class for Trachystoma (genus).
/// NCBI TaxId: 1167308
/// </summary>
public abstract class Trachystoma : Mugilidae, ITrachystoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trachystoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1167308;

    /// <inheritdoc />
    public virtual string GenusName => "Trachystoma";

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

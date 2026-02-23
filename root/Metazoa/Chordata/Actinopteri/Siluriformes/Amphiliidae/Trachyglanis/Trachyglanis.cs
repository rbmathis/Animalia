using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Amphiliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Amphiliidae.Trachyglanis;

/// <summary>
/// Abstract class for Trachyglanis (genus).
/// NCBI TaxId: 1233724
/// </summary>
public abstract class Trachyglanis : Amphiliidae, ITrachyglanis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trachyglanis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1233724;

    /// <inheritdoc />
    public virtual string GenusName => "Trachyglanis";

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

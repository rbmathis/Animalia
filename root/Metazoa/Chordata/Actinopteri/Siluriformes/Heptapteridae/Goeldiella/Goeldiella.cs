using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heptapteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heptapteridae.Goeldiella;

/// <summary>
/// Abstract class for Goeldiella (genus).
/// NCBI TaxId: 337660
/// </summary>
public abstract class Goeldiella : Heptapteridae, IGoeldiella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Goeldiella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 337660;

    /// <inheritdoc />
    public virtual string GenusName => "Goeldiella";

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

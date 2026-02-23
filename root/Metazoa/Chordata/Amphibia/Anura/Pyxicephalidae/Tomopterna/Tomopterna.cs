using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pyxicephalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pyxicephalidae.Tomopterna;

/// <summary>
/// Abstract class for Tomopterna (genus).
/// NCBI TaxId: 58514
/// </summary>
public abstract class Tomopterna : Pyxicephalidae, ITomopterna
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tomopterna";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 58514;

    /// <inheritdoc />
    public virtual string GenusName => "Tomopterna";

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

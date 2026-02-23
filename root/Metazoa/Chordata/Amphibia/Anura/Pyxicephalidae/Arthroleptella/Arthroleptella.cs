using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pyxicephalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pyxicephalidae.Arthroleptella;

/// <summary>
/// Abstract class for Arthroleptella (genus).
/// NCBI TaxId: 150241
/// </summary>
public abstract class Arthroleptella : Pyxicephalidae, IArthroleptella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Arthroleptella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 150241;

    /// <inheritdoc />
    public virtual string GenusName => "Arthroleptella";

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

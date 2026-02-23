using AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Pyxis;

/// <summary>
/// Abstract class for Pyxis (genus).
/// NCBI TaxId: 66192
/// </summary>
public abstract class Pyxis : Testudinidae, IPyxis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pyxis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 66192;

    /// <inheritdoc />
    public virtual string GenusName => "Pyxis";

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

using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae.Oreothraupis;

/// <summary>
/// Abstract class for Oreothraupis (genus).
/// NCBI TaxId: 1271579
/// </summary>
public abstract class Oreothraupis : Passerellidae, IOreothraupis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oreothraupis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1271579;

    /// <inheritdoc />
    public virtual string GenusName => "Oreothraupis";

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

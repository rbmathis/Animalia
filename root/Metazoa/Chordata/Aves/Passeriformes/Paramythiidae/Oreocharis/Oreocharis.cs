using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paramythiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paramythiidae.Oreocharis;

/// <summary>
/// Abstract class for Oreocharis (genus).
/// NCBI TaxId: 979198
/// </summary>
public abstract class Oreocharis : Paramythiidae, IOreocharis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oreocharis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 979198;

    /// <inheritdoc />
    public virtual string GenusName => "Oreocharis";

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

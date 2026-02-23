using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae.Lucigadus;

/// <summary>
/// Abstract class for Lucigadus (genus).
/// NCBI TaxId: 630735
/// </summary>
public abstract class Lucigadus : Macrouridae, ILucigadus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lucigadus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 630735;

    /// <inheritdoc />
    public virtual string GenusName => "Lucigadus";

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

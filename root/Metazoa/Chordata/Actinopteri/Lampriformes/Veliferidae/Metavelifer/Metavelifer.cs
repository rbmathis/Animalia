using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lampriformes.Veliferidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lampriformes.Veliferidae.Metavelifer;

/// <summary>
/// Abstract class for Metavelifer (genus).
/// NCBI TaxId: 81375
/// </summary>
public abstract class Metavelifer : Veliferidae, IMetavelifer
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Metavelifer";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 81375;

    /// <inheritdoc />
    public virtual string GenusName => "Metavelifer";

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

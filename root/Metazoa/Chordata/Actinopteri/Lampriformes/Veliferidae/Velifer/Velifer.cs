using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lampriformes.Veliferidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lampriformes.Veliferidae.Velifer;

/// <summary>
/// Abstract class for Velifer (genus).
/// NCBI TaxId: 334363
/// </summary>
public abstract class Velifer : Veliferidae, IVelifer
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Velifer";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 334363;

    /// <inheritdoc />
    public virtual string GenusName => "Velifer";

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

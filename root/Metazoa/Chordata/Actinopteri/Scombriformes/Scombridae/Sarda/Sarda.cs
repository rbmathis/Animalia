using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Scombridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Scombridae.Sarda;

/// <summary>
/// Abstract class for Sarda (genus).
/// NCBI TaxId: 8229
/// </summary>
public abstract class Sarda : Scombridae, ISarda
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sarda";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8229;

    /// <inheritdoc />
    public virtual string GenusName => "Sarda";

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

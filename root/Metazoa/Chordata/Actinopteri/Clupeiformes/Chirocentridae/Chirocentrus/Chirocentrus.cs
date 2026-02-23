using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Chirocentridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Chirocentridae.Chirocentrus;

/// <summary>
/// Abstract class for Chirocentrus (genus).
/// NCBI TaxId: 94305
/// </summary>
public abstract class Chirocentrus : Chirocentridae, IChirocentrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chirocentrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 94305;

    /// <inheritdoc />
    public virtual string GenusName => "Chirocentrus";

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

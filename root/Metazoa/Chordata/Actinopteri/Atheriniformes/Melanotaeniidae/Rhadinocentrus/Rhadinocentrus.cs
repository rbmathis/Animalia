using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Melanotaeniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Melanotaeniidae.Rhadinocentrus;

/// <summary>
/// Abstract class for Rhadinocentrus (genus).
/// NCBI TaxId: 262100
/// </summary>
public abstract class Rhadinocentrus : Melanotaeniidae, IRhadinocentrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhadinocentrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 262100;

    /// <inheritdoc />
    public virtual string GenusName => "Rhadinocentrus";

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

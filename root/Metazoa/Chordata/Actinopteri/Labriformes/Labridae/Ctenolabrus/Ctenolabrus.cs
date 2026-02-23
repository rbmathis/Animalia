using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Ctenolabrus;

/// <summary>
/// Abstract class for Ctenolabrus (genus).
/// NCBI TaxId: 171734
/// </summary>
public abstract class Ctenolabrus : Labridae, ICtenolabrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ctenolabrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 171734;

    /// <inheritdoc />
    public virtual string GenusName => "Ctenolabrus";

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

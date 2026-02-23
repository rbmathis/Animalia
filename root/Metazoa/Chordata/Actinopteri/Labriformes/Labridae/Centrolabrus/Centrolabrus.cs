using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Centrolabrus;

/// <summary>
/// Abstract class for Centrolabrus (genus).
/// NCBI TaxId: 171730
/// </summary>
public abstract class Centrolabrus : Labridae, ICentrolabrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Centrolabrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 171730;

    /// <inheritdoc />
    public virtual string GenusName => "Centrolabrus";

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

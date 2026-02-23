using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Minilabrus;

/// <summary>
/// Abstract class for Minilabrus (genus).
/// NCBI TaxId: 3362384
/// </summary>
public abstract class Minilabrus : Labridae, IMinilabrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Minilabrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3362384;

    /// <inheritdoc />
    public virtual string GenusName => "Minilabrus";

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

using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Bodianus;

/// <summary>
/// Abstract class for Bodianus (genus).
/// NCBI TaxId: 241267
/// </summary>
public abstract class Bodianus : Labridae, IBodianus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bodianus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 241267;

    /// <inheritdoc />
    public virtual string GenusName => "Bodianus";

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

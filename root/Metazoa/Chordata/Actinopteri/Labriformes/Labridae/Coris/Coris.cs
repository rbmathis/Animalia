using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Coris;

/// <summary>
/// Abstract class for Coris (genus).
/// NCBI TaxId: 126328
/// </summary>
public abstract class Coris : Labridae, ICoris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Coris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 126328;

    /// <inheritdoc />
    public virtual string GenusName => "Coris";

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

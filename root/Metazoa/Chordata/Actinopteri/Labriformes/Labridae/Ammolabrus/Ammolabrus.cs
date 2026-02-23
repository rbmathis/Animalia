using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Ammolabrus;

/// <summary>
/// Abstract class for Ammolabrus (genus).
/// NCBI TaxId: 2608470
/// </summary>
public abstract class Ammolabrus : Labridae, IAmmolabrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ammolabrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2608470;

    /// <inheritdoc />
    public virtual string GenusName => "Ammolabrus";

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

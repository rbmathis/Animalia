using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Botiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Botiidae.Syncrossus;

/// <summary>
/// Abstract class for Syncrossus (genus).
/// NCBI TaxId: 322117
/// </summary>
public abstract class Syncrossus : Botiidae, ISyncrossus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Syncrossus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 322117;

    /// <inheritdoc />
    public virtual string GenusName => "Syncrossus";

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

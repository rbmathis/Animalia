using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae.Cochleoceps;

/// <summary>
/// Abstract class for Cochleoceps (genus).
/// NCBI TaxId: 1986069
/// </summary>
public abstract class Cochleoceps : Gobiesocidae, ICochleoceps
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cochleoceps";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1986069;

    /// <inheritdoc />
    public virtual string GenusName => "Cochleoceps";

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

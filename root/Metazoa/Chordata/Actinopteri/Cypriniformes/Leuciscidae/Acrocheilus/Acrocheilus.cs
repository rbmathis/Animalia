using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Acrocheilus;

/// <summary>
/// Abstract class for Acrocheilus (genus).
/// NCBI TaxId: 67536
/// </summary>
public abstract class Acrocheilus : Leuciscidae, IAcrocheilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acrocheilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 67536;

    /// <inheritdoc />
    public virtual string GenusName => "Acrocheilus";

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

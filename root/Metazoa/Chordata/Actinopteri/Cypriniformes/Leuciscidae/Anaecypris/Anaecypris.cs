using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Anaecypris;

/// <summary>
/// Abstract class for Anaecypris (genus).
/// NCBI TaxId: 71182
/// </summary>
public abstract class Anaecypris : Leuciscidae, IAnaecypris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anaecypris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 71182;

    /// <inheritdoc />
    public virtual string GenusName => "Anaecypris";

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

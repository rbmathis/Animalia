using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Hemiculter;

/// <summary>
/// Abstract class for Hemiculter (genus).
/// NCBI TaxId: 75349
/// </summary>
public abstract class Hemiculter : Xenocyprididae, IHemiculter
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemiculter";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 75349;

    /// <inheritdoc />
    public virtual string GenusName => "Hemiculter";

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

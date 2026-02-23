using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Leuciscus;

/// <summary>
/// Abstract class for Leuciscus (genus).
/// NCBI TaxId: 8283
/// </summary>
public abstract class Leuciscus : Leuciscidae, ILeuciscus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leuciscus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8283;

    /// <inheritdoc />
    public virtual string GenusName => "Leuciscus";

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

using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Hemigobius;

/// <summary>
/// Abstract class for Hemigobius (genus).
/// NCBI TaxId: 508045
/// </summary>
public abstract class Hemigobius : Gobiidae, IHemigobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemigobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 508045;

    /// <inheritdoc />
    public virtual string GenusName => "Hemigobius";

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

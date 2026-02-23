using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Aspredinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Aspredinidae.Xyliphius;

/// <summary>
/// Abstract class for Xyliphius (genus).
/// NCBI TaxId: 1312700
/// </summary>
public abstract class Xyliphius : Aspredinidae, IXyliphius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xyliphius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1312700;

    /// <inheritdoc />
    public virtual string GenusName => "Xyliphius";

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

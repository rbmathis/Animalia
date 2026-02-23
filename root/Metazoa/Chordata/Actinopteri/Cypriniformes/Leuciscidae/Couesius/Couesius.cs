using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Couesius;

/// <summary>
/// Abstract class for Couesius (genus).
/// NCBI TaxId: 67538
/// </summary>
public abstract class Couesius : Leuciscidae, ICouesius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Couesius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 67538;

    /// <inheritdoc />
    public virtual string GenusName => "Couesius";

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

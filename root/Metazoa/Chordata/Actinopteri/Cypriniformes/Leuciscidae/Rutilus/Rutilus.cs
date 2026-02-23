using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Rutilus;

/// <summary>
/// Abstract class for Rutilus (genus).
/// NCBI TaxId: 48667
/// </summary>
public abstract class Rutilus : Leuciscidae, IRutilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rutilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 48667;

    /// <inheritdoc />
    public virtual string GenusName => "Rutilus";

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

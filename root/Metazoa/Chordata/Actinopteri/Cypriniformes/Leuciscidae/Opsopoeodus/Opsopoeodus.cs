using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Opsopoeodus;

/// <summary>
/// Abstract class for Opsopoeodus (genus).
/// NCBI TaxId: 36793
/// </summary>
public abstract class Opsopoeodus : Leuciscidae, IOpsopoeodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Opsopoeodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 36793;

    /// <inheritdoc />
    public virtual string GenusName => "Opsopoeodus";

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

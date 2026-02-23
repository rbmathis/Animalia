using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Dionda;

/// <summary>
/// Abstract class for Dionda (genus).
/// NCBI TaxId: 232985
/// </summary>
public abstract class Dionda : Leuciscidae, IDionda
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dionda";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 232985;

    /// <inheritdoc />
    public virtual string GenusName => "Dionda";

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

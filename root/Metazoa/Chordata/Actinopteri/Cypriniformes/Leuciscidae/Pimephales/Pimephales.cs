using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Pimephales;

/// <summary>
/// Abstract class for Pimephales (genus).
/// NCBI TaxId: 51137
/// </summary>
public abstract class Pimephales : Leuciscidae, IPimephales
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pimephales";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 51137;

    /// <inheritdoc />
    public virtual string GenusName => "Pimephales";

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

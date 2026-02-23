using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Codoma;

/// <summary>
/// Abstract class for Codoma (genus).
/// NCBI TaxId: 232983
/// </summary>
public abstract class Codoma : Leuciscidae, ICodoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Codoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 232983;

    /// <inheritdoc />
    public virtual string GenusName => "Codoma";

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

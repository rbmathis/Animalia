using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Rhinichthys;

/// <summary>
/// Abstract class for Rhinichthys (genus).
/// NCBI TaxId: 67555
/// </summary>
public abstract class Rhinichthys : Leuciscidae, IRhinichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhinichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 67555;

    /// <inheritdoc />
    public virtual string GenusName => "Rhinichthys";

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

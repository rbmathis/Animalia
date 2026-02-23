using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Algansea;

/// <summary>
/// Abstract class for Algansea (genus).
/// NCBI TaxId: 364077
/// </summary>
public abstract class Algansea : Leuciscidae, IAlgansea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Algansea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 364077;

    /// <inheritdoc />
    public virtual string GenusName => "Algansea";

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

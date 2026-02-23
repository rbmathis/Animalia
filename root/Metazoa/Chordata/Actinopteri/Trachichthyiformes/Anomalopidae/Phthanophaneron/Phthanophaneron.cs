using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Trachichthyiformes.Anomalopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Trachichthyiformes.Anomalopidae.Phthanophaneron;

/// <summary>
/// Abstract class for Phthanophaneron (genus).
/// NCBI TaxId: 2570690
/// </summary>
public abstract class Phthanophaneron : Anomalopidae, IPhthanophaneron
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phthanophaneron";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2570690;

    /// <inheritdoc />
    public virtual string GenusName => "Phthanophaneron";

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

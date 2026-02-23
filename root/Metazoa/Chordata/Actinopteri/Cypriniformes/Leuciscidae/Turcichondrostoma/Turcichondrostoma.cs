using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Turcichondrostoma;

/// <summary>
/// Abstract class for Turcichondrostoma (genus).
/// NCBI TaxId: 3074905
/// </summary>
public abstract class Turcichondrostoma : Leuciscidae, ITurcichondrostoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Turcichondrostoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3074905;

    /// <inheritdoc />
    public virtual string GenusName => "Turcichondrostoma";

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

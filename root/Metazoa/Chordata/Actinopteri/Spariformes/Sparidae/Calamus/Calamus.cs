using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Calamus;

/// <summary>
/// Abstract class for Calamus (genus).
/// NCBI TaxId: 119695
/// </summary>
public abstract class Calamus : Sparidae, ICalamus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Calamus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 119695;

    /// <inheritdoc />
    public virtual string GenusName => "Calamus";

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

using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Spintherobolidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Spintherobolidae.Spintherobolus;

/// <summary>
/// Abstract class for Spintherobolus (genus).
/// NCBI TaxId: 930386
/// </summary>
public abstract class Spintherobolus : Spintherobolidae, ISpintherobolus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Spintherobolus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 930386;

    /// <inheritdoc />
    public virtual string GenusName => "Spintherobolus";

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

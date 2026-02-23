using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Alestidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Alestidae.Phenacogrammus;

/// <summary>
/// Abstract class for Phenacogrammus (genus).
/// NCBI TaxId: 42485
/// </summary>
public abstract class Phenacogrammus : Alestidae, IPhenacogrammus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phenacogrammus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42485;

    /// <inheritdoc />
    public virtual string GenusName => "Phenacogrammus";

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

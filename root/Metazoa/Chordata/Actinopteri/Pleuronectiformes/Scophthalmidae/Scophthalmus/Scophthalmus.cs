using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Scophthalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Scophthalmidae.Scophthalmus;

/// <summary>
/// Abstract class for Scophthalmus (genus).
/// NCBI TaxId: 52903
/// </summary>
public abstract class Scophthalmus : Scophthalmidae, IScophthalmus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scophthalmus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 52903;

    /// <inheritdoc />
    public virtual string GenusName => "Scophthalmus";

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

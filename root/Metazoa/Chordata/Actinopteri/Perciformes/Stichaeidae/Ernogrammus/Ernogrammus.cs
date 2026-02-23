using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae.Ernogrammus;

/// <summary>
/// Abstract class for Ernogrammus (genus).
/// NCBI TaxId: 641278
/// </summary>
public abstract class Ernogrammus : Stichaeidae, IErnogrammus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ernogrammus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 641278;

    /// <inheritdoc />
    public virtual string GenusName => "Ernogrammus";

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

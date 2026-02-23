using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Boleophthalmus;

/// <summary>
/// Abstract class for Boleophthalmus (genus).
/// NCBI TaxId: 150287
/// </summary>
public abstract class Boleophthalmus : Gobiidae, IBoleophthalmus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Boleophthalmus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 150287;

    /// <inheritdoc />
    public virtual string GenusName => "Boleophthalmus";

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

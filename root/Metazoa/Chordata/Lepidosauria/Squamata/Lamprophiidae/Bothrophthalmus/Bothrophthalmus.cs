using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Bothrophthalmus;

/// <summary>
/// Abstract class for Bothrophthalmus (genus).
/// NCBI TaxId: 186542
/// </summary>
public abstract class Bothrophthalmus : Lamprophiidae, IBothrophthalmus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bothrophthalmus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 186542;

    /// <inheritdoc />
    public virtual string GenusName => "Bothrophthalmus";

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

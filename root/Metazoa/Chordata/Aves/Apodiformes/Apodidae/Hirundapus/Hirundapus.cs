using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Apodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Apodidae.Hirundapus;

/// <summary>
/// Abstract class for Hirundapus (genus).
/// NCBI TaxId: 190689
/// </summary>
public abstract class Hirundapus : Apodidae, IHirundapus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hirundapus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 190689;

    /// <inheritdoc />
    public virtual string GenusName => "Hirundapus";

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

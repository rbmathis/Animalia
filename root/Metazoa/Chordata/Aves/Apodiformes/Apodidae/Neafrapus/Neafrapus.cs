using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Apodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Apodidae.Neafrapus;

/// <summary>
/// Abstract class for Neafrapus (genus).
/// NCBI TaxId: 243323
/// </summary>
public abstract class Neafrapus : Apodidae, INeafrapus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neafrapus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 243323;

    /// <inheritdoc />
    public virtual string GenusName => "Neafrapus";

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

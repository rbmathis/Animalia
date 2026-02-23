using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Pyrrhoplectes;

/// <summary>
/// Abstract class for Pyrrhoplectes (genus).
/// NCBI TaxId: 552618
/// </summary>
public abstract class Pyrrhoplectes : Fringillidae, IPyrrhoplectes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pyrrhoplectes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 552618;

    /// <inheritdoc />
    public virtual string GenusName => "Pyrrhoplectes";

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

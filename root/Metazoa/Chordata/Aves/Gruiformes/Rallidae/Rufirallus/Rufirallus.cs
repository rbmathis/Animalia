using AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Rufirallus;

/// <summary>
/// Abstract class for Rufirallus (genus).
/// NCBI TaxId: 2861783
/// </summary>
public abstract class Rufirallus : Rallidae, IRufirallus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rufirallus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2861783;

    /// <inheritdoc />
    public virtual string GenusName => "Rufirallus";

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

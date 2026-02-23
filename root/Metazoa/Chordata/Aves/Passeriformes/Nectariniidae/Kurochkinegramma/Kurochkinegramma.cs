using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Nectariniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Nectariniidae.Kurochkinegramma;

/// <summary>
/// Abstract class for Kurochkinegramma (genus).
/// NCBI TaxId: 2478814
/// </summary>
public abstract class Kurochkinegramma : Nectariniidae, IKurochkinegramma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kurochkinegramma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2478814;

    /// <inheritdoc />
    public virtual string GenusName => "Kurochkinegramma";

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

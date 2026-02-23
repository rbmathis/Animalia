using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Cracidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Cracidae.Oreophasis;

/// <summary>
/// Abstract class for Oreophasis (genus).
/// NCBI TaxId: 125066
/// </summary>
public abstract class Oreophasis : Cracidae, IOreophasis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oreophasis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 125066;

    /// <inheritdoc />
    public virtual string GenusName => "Oreophasis";

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

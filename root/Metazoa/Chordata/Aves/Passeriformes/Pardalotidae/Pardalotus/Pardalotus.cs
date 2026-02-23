using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pardalotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pardalotidae.Pardalotus;

/// <summary>
/// Abstract class for Pardalotus (genus).
/// NCBI TaxId: 108839
/// </summary>
public abstract class Pardalotus : Pardalotidae, IPardalotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pardalotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 108839;

    /// <inheritdoc />
    public virtual string GenusName => "Pardalotus";

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

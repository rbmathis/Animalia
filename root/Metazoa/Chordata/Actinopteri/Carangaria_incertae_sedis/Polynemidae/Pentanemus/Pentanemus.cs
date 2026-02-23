using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangaria_incertae_sedis.Polynemidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangaria_incertae_sedis.Polynemidae.Pentanemus;

/// <summary>
/// Abstract class for Pentanemus (genus).
/// NCBI TaxId: 206146
/// </summary>
public abstract class Pentanemus : Polynemidae, IPentanemus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pentanemus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 206146;

    /// <inheritdoc />
    public virtual string GenusName => "Pentanemus";

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

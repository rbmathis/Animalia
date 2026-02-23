using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangaria_incertae_sedis.Polynemidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangaria_incertae_sedis.Polynemidae.Polynemus;

/// <summary>
/// Abstract class for Polynemus (genus).
/// NCBI TaxId: 232320
/// </summary>
public abstract class Polynemus : Polynemidae, IPolynemus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Polynemus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 232320;

    /// <inheritdoc />
    public virtual string GenusName => "Polynemus";

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

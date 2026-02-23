using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangaria_incertae_sedis.Polynemidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangaria_incertae_sedis.Polynemidae.Parapolynemus;

/// <summary>
/// Abstract class for Parapolynemus (genus).
/// NCBI TaxId: 2910466
/// </summary>
public abstract class Parapolynemus : Polynemidae, IParapolynemus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parapolynemus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2910466;

    /// <inheritdoc />
    public virtual string GenusName => "Parapolynemus";

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

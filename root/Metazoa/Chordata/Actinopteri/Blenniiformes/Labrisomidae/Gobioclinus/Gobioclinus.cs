using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Labrisomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Labrisomidae.Gobioclinus;

/// <summary>
/// Abstract class for Gobioclinus (genus).
/// NCBI TaxId: 2566710
/// </summary>
public abstract class Gobioclinus : Labrisomidae, IGobioclinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gobioclinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2566710;

    /// <inheritdoc />
    public virtual string GenusName => "Gobioclinus";

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

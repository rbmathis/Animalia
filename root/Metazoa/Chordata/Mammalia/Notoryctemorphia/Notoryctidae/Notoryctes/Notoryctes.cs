using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Notoryctemorphia.Notoryctidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Notoryctemorphia.Notoryctidae.Notoryctes;

/// <summary>
/// Abstract class for Notoryctes (genus).
/// NCBI TaxId: 37887
/// </summary>
public abstract class Notoryctes : Notoryctidae, INotoryctes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Notoryctes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 37887;

    /// <inheritdoc />
    public virtual string GenusName => "Notoryctes";

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

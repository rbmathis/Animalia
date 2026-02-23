using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Limnodynastidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Limnodynastidae.Limnodynastes;

/// <summary>
/// Abstract class for Limnodynastes (genus).
/// NCBI TaxId: 30361
/// </summary>
public abstract class Limnodynastes : Limnodynastidae, ILimnodynastes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Limnodynastes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 30361;

    /// <inheritdoc />
    public virtual string GenusName => "Limnodynastes";

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

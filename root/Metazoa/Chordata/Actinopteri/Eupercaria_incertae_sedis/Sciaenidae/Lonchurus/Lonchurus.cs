using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Lonchurus;

/// <summary>
/// Abstract class for Lonchurus (genus).
/// NCBI TaxId: 278727
/// </summary>
public abstract class Lonchurus : Sciaenidae, ILonchurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lonchurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 278727;

    /// <inheritdoc />
    public virtual string GenusName => "Lonchurus";

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

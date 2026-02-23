using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Plesiopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Plesiopidae.Steeneichthys;

/// <summary>
/// Abstract class for Steeneichthys (genus).
/// NCBI TaxId: 1064601
/// </summary>
public abstract class Steeneichthys : Plesiopidae, ISteeneichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Steeneichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1064601;

    /// <inheritdoc />
    public virtual string GenusName => "Steeneichthys";

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

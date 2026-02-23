using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pseudochromidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pseudochromidae.Lubbockichthys;

/// <summary>
/// Abstract class for Lubbockichthys (genus).
/// NCBI TaxId: 1648457
/// </summary>
public abstract class Lubbockichthys : Pseudochromidae, ILubbockichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lubbockichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1648457;

    /// <inheritdoc />
    public virtual string GenusName => "Lubbockichthys";

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

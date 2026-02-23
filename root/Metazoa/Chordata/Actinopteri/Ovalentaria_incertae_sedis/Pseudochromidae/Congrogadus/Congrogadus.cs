using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pseudochromidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pseudochromidae.Congrogadus;

/// <summary>
/// Abstract class for Congrogadus (genus).
/// NCBI TaxId: 659121
/// </summary>
public abstract class Congrogadus : Pseudochromidae, ICongrogadus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Congrogadus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 659121;

    /// <inheritdoc />
    public virtual string GenusName => "Congrogadus";

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

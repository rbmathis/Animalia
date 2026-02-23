using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pseudochromidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pseudochromidae.Manonichthys;

/// <summary>
/// Abstract class for Manonichthys (genus).
/// NCBI TaxId: 1648460
/// </summary>
public abstract class Manonichthys : Pseudochromidae, IManonichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Manonichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1648460;

    /// <inheritdoc />
    public virtual string GenusName => "Manonichthys";

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

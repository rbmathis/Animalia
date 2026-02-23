using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pseudochromidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pseudochromidae.Oxycercichthys;

/// <summary>
/// Abstract class for Oxycercichthys (genus).
/// NCBI TaxId: 1647201
/// </summary>
public abstract class Oxycercichthys : Pseudochromidae, IOxycercichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oxycercichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1647201;

    /// <inheritdoc />
    public virtual string GenusName => "Oxycercichthys";

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

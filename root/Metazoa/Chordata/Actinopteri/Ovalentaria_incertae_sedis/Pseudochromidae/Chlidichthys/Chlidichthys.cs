using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pseudochromidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pseudochromidae.Chlidichthys;

/// <summary>
/// Abstract class for Chlidichthys (genus).
/// NCBI TaxId: 1910787
/// </summary>
public abstract class Chlidichthys : Pseudochromidae, IChlidichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chlidichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1910787;

    /// <inheritdoc />
    public virtual string GenusName => "Chlidichthys";

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

using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pseudochromidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pseudochromidae.Natalichthys;

/// <summary>
/// Abstract class for Natalichthys (genus).
/// NCBI TaxId: 1003963
/// </summary>
public abstract class Natalichthys : Pseudochromidae, INatalichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Natalichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1003963;

    /// <inheritdoc />
    public virtual string GenusName => "Natalichthys";

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

using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pseudochromidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pseudochromidae.Cypho;

/// <summary>
/// Abstract class for Cypho (genus).
/// NCBI TaxId: 646042
/// </summary>
public abstract class Cypho : Pseudochromidae, ICypho
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cypho";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 646042;

    /// <inheritdoc />
    public virtual string GenusName => "Cypho";

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

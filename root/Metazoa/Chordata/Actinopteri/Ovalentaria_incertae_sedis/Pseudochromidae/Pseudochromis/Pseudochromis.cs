using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pseudochromidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pseudochromidae.Pseudochromis;

/// <summary>
/// Abstract class for Pseudochromis (genus).
/// NCBI TaxId: 280672
/// </summary>
public abstract class Pseudochromis : Pseudochromidae, IPseudochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 280672;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudochromis";

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

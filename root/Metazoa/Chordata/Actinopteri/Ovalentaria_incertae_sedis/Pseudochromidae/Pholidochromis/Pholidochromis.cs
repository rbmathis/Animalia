using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pseudochromidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pseudochromidae.Pholidochromis;

/// <summary>
/// Abstract class for Pholidochromis (genus).
/// NCBI TaxId: 1206937
/// </summary>
public abstract class Pholidochromis : Pseudochromidae, IPholidochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pholidochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1206937;

    /// <inheritdoc />
    public virtual string GenusName => "Pholidochromis";

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

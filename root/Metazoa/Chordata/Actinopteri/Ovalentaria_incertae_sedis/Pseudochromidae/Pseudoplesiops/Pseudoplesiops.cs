using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pseudochromidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pseudochromidae.Pseudoplesiops;

/// <summary>
/// Abstract class for Pseudoplesiops (genus).
/// NCBI TaxId: 659124
/// </summary>
public abstract class Pseudoplesiops : Pseudochromidae, IPseudoplesiops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudoplesiops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 659124;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudoplesiops";

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

using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Pseudosimochromis;

/// <summary>
/// Abstract class for Pseudosimochromis (genus).
/// NCBI TaxId: 167847
/// </summary>
public abstract class Pseudosimochromis : Cichlidae, IPseudosimochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudosimochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 167847;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudosimochromis";

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

using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Pelmatochromis;

/// <summary>
/// Abstract class for Pelmatochromis (genus).
/// NCBI TaxId: 302986
/// </summary>
public abstract class Pelmatochromis : Cichlidae, IPelmatochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pelmatochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 302986;

    /// <inheritdoc />
    public virtual string GenusName => "Pelmatochromis";

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

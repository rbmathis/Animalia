using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Congochromis;

/// <summary>
/// Abstract class for Congochromis (genus).
/// NCBI TaxId: 1069629
/// </summary>
public abstract class Congochromis : Cichlidae, ICongochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Congochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1069629;

    /// <inheritdoc />
    public virtual string GenusName => "Congochromis";

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

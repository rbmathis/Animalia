using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Otopharynx;

/// <summary>
/// Abstract class for Otopharynx (genus).
/// NCBI TaxId: 137557
/// </summary>
public abstract class Otopharynx : Cichlidae, IOtopharynx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Otopharynx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 137557;

    /// <inheritdoc />
    public virtual string GenusName => "Otopharynx";

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

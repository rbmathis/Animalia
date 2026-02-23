using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Ctenopharynx;

/// <summary>
/// Abstract class for Ctenopharynx (genus).
/// NCBI TaxId: 323767
/// </summary>
public abstract class Ctenopharynx : Cichlidae, ICtenopharynx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ctenopharynx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 323767;

    /// <inheritdoc />
    public virtual string GenusName => "Ctenopharynx";

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

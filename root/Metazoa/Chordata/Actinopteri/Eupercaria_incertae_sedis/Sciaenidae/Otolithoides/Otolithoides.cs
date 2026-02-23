using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Otolithoides;

/// <summary>
/// Abstract class for Otolithoides (genus).
/// NCBI TaxId: 459286
/// </summary>
public abstract class Otolithoides : Sciaenidae, IOtolithoides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Otolithoides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 459286;

    /// <inheritdoc />
    public virtual string GenusName => "Otolithoides";

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

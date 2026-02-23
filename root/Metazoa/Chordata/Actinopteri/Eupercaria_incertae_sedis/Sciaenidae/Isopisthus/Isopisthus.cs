using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Isopisthus;

/// <summary>
/// Abstract class for Isopisthus (genus).
/// NCBI TaxId: 666536
/// </summary>
public abstract class Isopisthus : Sciaenidae, IIsopisthus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Isopisthus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 666536;

    /// <inheritdoc />
    public virtual string GenusName => "Isopisthus";

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

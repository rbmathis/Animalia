using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Pseudotolithus;

/// <summary>
/// Abstract class for Pseudotolithus (genus).
/// NCBI TaxId: 349647
/// </summary>
public abstract class Pseudotolithus : Sciaenidae, IPseudotolithus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudotolithus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 349647;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudotolithus";

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

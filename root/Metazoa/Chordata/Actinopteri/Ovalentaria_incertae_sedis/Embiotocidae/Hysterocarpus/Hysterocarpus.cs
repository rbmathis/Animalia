using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Embiotocidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Embiotocidae.Hysterocarpus;

/// <summary>
/// Abstract class for Hysterocarpus (genus).
/// NCBI TaxId: 100195
/// </summary>
public abstract class Hysterocarpus : Embiotocidae, IHysterocarpus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hysterocarpus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 100195;

    /// <inheritdoc />
    public virtual string GenusName => "Hysterocarpus";

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

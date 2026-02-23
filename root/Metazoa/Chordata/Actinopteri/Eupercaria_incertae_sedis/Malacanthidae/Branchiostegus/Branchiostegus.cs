using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Malacanthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Malacanthidae.Branchiostegus;

/// <summary>
/// Abstract class for Branchiostegus (genus).
/// NCBI TaxId: 270561
/// </summary>
public abstract class Branchiostegus : Malacanthidae, IBranchiostegus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Branchiostegus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 270561;

    /// <inheritdoc />
    public virtual string GenusName => "Branchiostegus";

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

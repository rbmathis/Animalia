using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Akysidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Akysidae.Acrochordonichthys;

/// <summary>
/// Abstract class for Acrochordonichthys (genus).
/// NCBI TaxId: 337690
/// </summary>
public abstract class Acrochordonichthys : Akysidae, IAcrochordonichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acrochordonichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 337690;

    /// <inheritdoc />
    public virtual string GenusName => "Acrochordonichthys";

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

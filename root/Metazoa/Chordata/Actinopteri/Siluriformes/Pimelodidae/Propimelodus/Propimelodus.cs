using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae.Propimelodus;

/// <summary>
/// Abstract class for Propimelodus (genus).
/// NCBI TaxId: 3102728
/// </summary>
public abstract class Propimelodus : Pimelodidae, IPropimelodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Propimelodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3102728;

    /// <inheritdoc />
    public virtual string GenusName => "Propimelodus";

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

using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Konia;

/// <summary>
/// Abstract class for Konia (genus).
/// NCBI TaxId: 296562
/// </summary>
public abstract class Konia : Cichlidae, IKonia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Konia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 296562;

    /// <inheritdoc />
    public virtual string GenusName => "Konia";

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

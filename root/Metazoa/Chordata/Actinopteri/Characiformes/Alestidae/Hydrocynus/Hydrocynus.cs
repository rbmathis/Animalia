using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Alestidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Alestidae.Hydrocynus;

/// <summary>
/// Abstract class for Hydrocynus (genus).
/// NCBI TaxId: 61320
/// </summary>
public abstract class Hydrocynus : Alestidae, IHydrocynus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hydrocynus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 61320;

    /// <inheritdoc />
    public virtual string GenusName => "Hydrocynus";

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

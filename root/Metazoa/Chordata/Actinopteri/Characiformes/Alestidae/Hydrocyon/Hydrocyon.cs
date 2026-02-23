using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Alestidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Alestidae.Hydrocyon;

/// <summary>
/// Abstract class for Hydrocyon (genus).
/// NCBI TaxId: 42572
/// </summary>
public abstract class Hydrocyon : Alestidae, IHydrocyon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hydrocyon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42572;

    /// <inheritdoc />
    public virtual string GenusName => "Hydrocyon";

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

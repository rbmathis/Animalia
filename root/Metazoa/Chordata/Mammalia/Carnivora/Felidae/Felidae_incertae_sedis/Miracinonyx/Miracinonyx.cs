using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Felidae_incertae_sedis;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Felidae_incertae_sedis.Miracinonyx;

/// <summary>
/// Abstract class for Miracinonyx (genus).
/// NCBI TaxId: 339611
/// </summary>
public abstract class Miracinonyx : Felidae_incertae_sedis, IMiracinonyx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Miracinonyx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 339611;

    /// <inheritdoc />
    public virtual string GenusName => "Miracinonyx";

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

using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Felidae_incertae_sedis;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Felidae_incertae_sedis.Smilodon;

/// <summary>
/// Abstract class for Smilodon (genus).
/// NCBI TaxId: 13265
/// </summary>
public abstract class Smilodon : Felidae_incertae_sedis, ISmilodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Smilodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 13265;

    /// <inheritdoc />
    public virtual string GenusName => "Smilodon";

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

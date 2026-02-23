using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Herpestidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Herpestidae.Paracynictis;

/// <summary>
/// Abstract class for Paracynictis (genus).
/// NCBI TaxId: 311559
/// </summary>
public abstract class Paracynictis : Herpestidae, IParacynictis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paracynictis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 311559;

    /// <inheritdoc />
    public virtual string GenusName => "Paracynictis";

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

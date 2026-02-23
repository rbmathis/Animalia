using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Molossidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Molossidae.Tomopeas;

/// <summary>
/// Abstract class for Tomopeas (genus).
/// NCBI TaxId: 27631
/// </summary>
public abstract class Tomopeas : Molossidae, ITomopeas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tomopeas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 27631;

    /// <inheritdoc />
    public virtual string GenusName => "Tomopeas";

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
